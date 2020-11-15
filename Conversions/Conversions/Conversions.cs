using System;
namespace Conversions
{
    public class Conversions
    {

        //Default constructor.. class has no member variables so none are declared
        public Conversions()
        {

        }

        //Function converts the given feet(ft) and inches(in) into centimeters(cm)
        //Calls printCm
        public void convertFt_And_In_To_Cm(double ft, double inch)
        {
            double cm = (ft * 30.48) + (inch * 2.54);
            printCm(ft, inch, cm);
        }

        //Function is called by the convertFt_And_In_To_Cm(double &ft, double &in) function
        // and will display the input ft and in, as well as the converted cm value
        public void printCm(double ft, double inch, double cm)
        {
            Console.Write("\n\n" + ft + " feet, " + inch + " inches, is equivelant to " + cm + " centimeters.\n\n");
        }

        //Function converts the given pounds(lbs) into kilograms(kg)
        //Calls printKg
        public void convertLbs_To_Kg(double lbs)
        {
            double kg = lbs * 0.45359;
            printKg(lbs, kg);
        }

        //Function is called by the convertLbs_To_Kg(double &lbs) function
        // and will display the input lbs, as well as the converted kg value
        public void printKg(double lbs, double kg)
        {
            Console.Write("\n\n" + lbs + " pounds, is equivelant to " + kg + " kilograms.\n\n");
        }

        //Destructor
        ~Conversions()
        {
            Console.Write("I'm in the destructor for Conversions");
        }

    }
}
