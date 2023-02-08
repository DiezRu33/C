

using System.ComponentModel.DataAnnotations;

int value1 = 15;
int value2 = 15;
// no value in nmb3 cause is equal w/ realvaluethree;
int value3;

// define realvalue one;
int realvalueone = 3;
// line below commented cause theres NO equals between value 1 and his real value;
// so the result is the else if();
// value1 = realvalueone;

// this line is just like the first one;
int realvaluetwo = 10;
// value2 = realvaluetwo;

// this should EQUALIZE the value 3 and his real value
int realvaluethree = 1;
value3 = realvaluethree;

if (value1 == realvalueone){
    Console.WriteLine("El valor es igual a " + value1);
}else if (value1 != realvalueone)
{
    Console.WriteLine("El valor es distinto a " + realvalueone);
}
if (value2 == realvaluetwo)
{
    Console.WriteLine("El valor es igual a " + realvaluetwo);
}
else if (value2 != realvaluetwo)
{
    Console.WriteLine("El valor es distinto a " + realvaluetwo);
}
if (value3 == realvaluethree)
{
    Console.WriteLine("El valor es igual a " + realvaluethree);
}
else if (value3 != realvaluethree)
{
    Console.WriteLine("El valor es distinto a " + realvaluetwo);
}
