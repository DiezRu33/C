using System;

namespace NameSpace
{
    class ClassName
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Running...");

            String Subject = "Programming in C#";
            String School = "Platzi";

            Console.WriteLine("This is the original phrase");
            Console.WriteLine($"I'm " + Subject + " with " + School + "\n");

            String SubjectClone = "Programming in Python";
            String SchoolClone = School.Clone().ToString();

            Console.WriteLine("I'm learning about how to " + SubjectClone + " with the help of " + School + "\n");

            Console.WriteLine("between " + SubjectClone + " and " + Subject + ":");
            if (SubjectClone == Subject)
            {
                Console.WriteLine("Both of them are equal" + "\n");
            }
            else
            {
                Console.WriteLine(SubjectClone + " and " + Subject + " are not the same value\n");
            }

            Console.WriteLine("between " + School + " and " + SchoolClone);
            if (SchoolClone == School)
            {
                Console.WriteLine("They are both the same.");
            }
            else
            {
                Console.WriteLine(SchoolClone + " and " + School + " are differents");
            }

            Console.WriteLine("\nDifferent values, got a boolean");
            // False = 1;
            // True = 0;
            if (SubjectClone.CompareTo(Subject) == 1)
            {
                Console.WriteLine("Boolean value is False: " + SubjectClone.CompareTo(Subject));
            }
            else
            {
                Console.WriteLine("Boolean value is True: " + SubjectClone.CompareTo(Subject));
            }
            if (SchoolClone.CompareTo(School) == 1)
            {
                Console.WriteLine("Boolean value is True: " + SchoolClone.CompareTo(School));
            }
            else
            {
                Console.WriteLine("Boolean value is False: " + SchoolClone.CompareTo(School));
            }

            Console.WriteLine("\nContaint Method:");
            Console.WriteLine(SchoolClone.Contains("Pla"));
            if (SubjectClone.Contains("Pro"))
            {
                Console.WriteLine("It does");
            }
            else
            {
                Console.WriteLine("It doesn't");
            }

            if (SchoolClone.Contains("PlA"))
            {
                Console.WriteLine("It does");
            }
            else
            {
                Console.WriteLine("It doesn't");
            }

            Console.WriteLine("\nEndsWith()");

            Console.WriteLine(SchoolClone.EndsWith("tzi"));
            Console.WriteLine(SubjectClone.EndsWith("C#"));

            // StartsWith;
            Console.WriteLine(SchoolClone.StartsWith("edX"));
            Console.WriteLine(SubjectClone.StartsWith("Physics"));

            // Equals();
            // Works like CompareTo() and return bool;
            Console.WriteLine(SchoolClone.Equals(School));
            Console.WriteLine(SubjectClone.Equals(Subject));

            // IndexOf();
            // return the letter position
            Console.WriteLine(SchoolClone.IndexOf("z"));
            Console.WriteLine(SubjectClone.IndexOf("#"));

            // ToUpper() & ToLower();
            // return lower o mayus case;
            Console.WriteLine(SubjectClone.ToLower());
            Console.WriteLine(School.ToUpper());

            // Insert();
            // first parameter the index position, "string to add";
            Console.WriteLine(School.Insert(6, " ya que es de libre acceso."));

            // LastIndexOf();
            // return the last position of the character;
            Console.WriteLine(SchoolClone.LastIndexOf("s"));

            // Remove();
            // delete the characters of string giving the first and second index;
            Console.WriteLine(SchoolClone.Remove(1, 2));

            // Replace();
            // replace all the characters (first parameter) and return the second one;
            Console.WriteLine(SubjectClone.Replace("s", "z"));

            // Split();
            Console.WriteLine("\nThis is the split method:");
            String SchoolClone_v2 = "Massachussets Institute of Technology";

            String[] split = SchoolClone_v2.Split(new char[] { 's' });
            Console.WriteLine("first split: " + split[0]);
            Console.WriteLine("second split: " + split[2]);
            Console.WriteLine("third split: " + split[3]);

            // Substring();
            // return a part of the string accord to parameters in Substring(0,1);
            Console.WriteLine("\nSubstring() Method");
            Console.WriteLine(SchoolClone_v2.Substring(0, 12) + SchoolClone_v2.Substring(13, 13) + " Technology.");

            // ToChairArray();
            School.ToCharArray();

            // Trim();
            // W/ Trim(), the coast is clear;
            string TextWithSpaces = " hi, there spaces at the beginning and the last part ";
            Console.WriteLine(TextWithSpaces.Trim());

        }
    }
}