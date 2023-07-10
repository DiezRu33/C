# scrip hecho por chatgpt

#include <stdio.h>
#include <stdlib.h>
#include <curl/curl.h>
#include <cJSON.h>

#define API_KEY "TU_API_KEY"
#define API_ENDPOINT "https://api.openai.com/v1/chat/completions"

// Estructura para almacenar la respuesta de la API
struct MemoryStruct {
    char *memory;
    size_t size;
};

// Función para manejar la respuesta de la API
size_t WriteMemoryCallback(void *contents, size_t size, size_t nmemb, void *userp) {
    size_t realsize = size * nmemb;
    struct MemoryStruct *mem = (struct MemoryStruct *)userp;
    char *ptr = realloc(mem->memory, mem->size + realsize + 1);
    if (ptr == NULL) {
        printf("Error de memoria.\n");
        return 0;
    }
    mem->memory = ptr;
    memcpy(&(mem->memory[mem->size]), contents, realsize);
    mem->size += realsize;
    mem->memory[mem->size] = 0;
    return realsize;
}

// Función para enviar una solicitud a la API de ChatGPT
void send_message(const char *message) {
    CURL *curl;
    CURLcode res;
    struct curl_slist *headers = NULL;
    struct MemoryStruct chunk;
    chunk.memory = malloc(1);
    chunk.size = 0;

    curl_global_init(CURL_GLOBAL_DEFAULT);
    curl = curl_easy_init();
    if (curl) {
        // Establecer los encabezados de la solicitud
        headers = curl_slist_append(headers, "Content-Type: application/json");
        headers = curl_slist_append(headers, "Authorization: Bearer " API_KEY);

        // Crear el objeto JSON de la solicitud
        cJSON *json = cJSON_CreateObject();
        cJSON_AddItemToObject(json, "messages", cJSON_CreateStringArray(&message, 1));

        // Configurar y enviar la solicitud POST
        curl_easy_setopt(curl, CURLOPT_URL, API_ENDPOINT);
        curl_easy_setopt(curl, CURLOPT_HTTPHEADER, headers);
        curl_easy_setopt(curl, CURLOPT_POSTFIELDS, cJSON_Print(json));
        curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, WriteMemoryCallback);
        curl_easy_setopt(curl, CURLOPT_WRITEDATA, (void *)&chunk);
        res = curl_easy_perform(curl);

        if (res != CURLE_OK) {
            printf("Error al realizar la solicitud: %s\n", curl_easy_strerror(res));
        } else {
            // Analizar la respuesta JSON
            cJSON *response = cJSON_Parse(chunk.memory);
            cJSON *choices = cJSON_GetObjectItemCaseSensitive(response, "choices");
            if (cJSON_IsArray(choices) && cJSON_GetArraySize(choices) > 0) {
                cJSON *reply = cJSON_GetArrayItem(choices, 0);
                cJSON *text = cJSON_GetObjectItemCaseSensitive(reply, "message");
                if (cJSON_IsString(text)) {
                    printf("ChatGPT: %s\n", text->valuestring);
                }
            }
            cJSON_Delete(response);
        }

        // Liberar la memoria y cerrar la conexión CURL
        cJSON_Delete(json);
        curl_slist_free_all(headers);
        curl_easy_cleanup(curl);
    }

    curl_global_cleanup();
    free(chunk.memory);
}

int main() {
    char input[256];
    printf("Bienvenido al ChatGPT\n");
    printf("Escribe 'salir' para finalizar.\n");

    while (1) {
        printf("Usuario: ");
        fgets(input, sizeof(input), stdin);
        input[strcspn(input, "\n")] = '\0';

        if (strcmp(input, "salir") == 0) {
            break;
        }

        send_message(input);
    }

    return 0;
}
