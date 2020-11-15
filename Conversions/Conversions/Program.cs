using System;

namespace Conversions
{
    class Program
    {

        private static DerivedName yourName = new DerivedName();

        public static int Main()
        {

            String fname, lname, wholeName;
            Console.Write("\nPlease enter your first name: ");
            fname = Console.ReadLine();
            Console.Write("\nPlease enter your last name: ");
            lname = Console.ReadLine();

            yourName.setName(fname, lname);

            wholeName = yourName.getName();
            Console.WriteLine("*" + wholeName + "*");

            yourName.Print();

            while (displayMenu());

            return 0;

        }

        public static bool displayMenu()
        {

            bool goOrNo = true;

            Console.Write("\n\n");

            do
            {
                yourName.Print();
                Console.WriteLine(" please select one of the following: ");
                Console.WriteLine("Convert (F)eet and (I)nches to (C)entimeters (Press f, i, or c)");
                Console.WriteLine("Convert (P)ounds to (K)ilograms (Press p or k)");
                Console.WriteLine("Exit the converting program (Press x)");
                Console.Write("\nEnter choice: ");
            } while (goOrNo = getMenuChoice(ref goOrNo));

            return goOrNo;

        }

        public static bool getMenuChoice(ref bool goOrNo)
        {

            Conversions conv = new Conversions();
            double input1, input2;
            char input;

            input = Convert.ToChar(Console.ReadLine());
            switch (input)
            {
                case 'f':
                case 'i':
                case 'c':
                case 'F':
                case 'I':
                case 'C':
                    Console.Write("\nPlease enter feet and then press enter: ");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\nPlease enter inches and then press enter: ");
                    input2 = Convert.ToDouble(Console.ReadLine());
                    conv.convertFt_And_In_To_Cm(input1, input2);
                    return goOrNo;
                case 'p':
                case 'k':
                case 'P':
                case 'K':
                    Console.Write("\nPlease enter the number of pounds and then press enter: ");
                    input1 = Convert.ToDouble(Console.ReadLine());
                    conv.convertLbs_To_Kg(input1);
                    return goOrNo;
                case 'x':
                case 'X':
                    goOrNo = false;
                    return goOrNo;
                default:
                    Console.WriteLine("\nPlease enter a valid choice. Valid choices are \"f, i, c, p, k, or x\"\n");
                    return goOrNo;
            }

        }

    }
}
