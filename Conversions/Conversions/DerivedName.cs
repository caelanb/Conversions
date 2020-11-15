using System;
namespace Conversions
{
    public class DerivedName : Name
    {

        //holds the value of the last name
        private String lastName;

        //Alternate constructor, sets first and last name
        // if no parameters are given for a variable, the respective variable defaults to a null string
        public DerivedName(String fName, String lName) : base(fName)
        {
            lastName = lName;
        }

        //Default constructor, sets first and last name
        // each name variable defaults to null strings
        public DerivedName()
        {
            lastName = "";
        }

        //Function returns the first and last name of the individual
        public String getName()
        {
            String temp;
            temp = base.getName() + " " + lastName;
            return temp;
        }

        //Function sets the first and last name value to firstName and lastName respectively.
        // if no parameters are given.. the names defaults to null strings
        public void setName(String fName, String lName)
        {
            base.setName(fName);
            lastName = lName;
        }

        //Function prints the user's name to the screen
        public void Print()
        {
            base.Print();
            Console.Write(" " + lastName);
        }

        //
        ~DerivedName()
        {
            Console.Write("I'm in the destructor for derivedName");
        }

    }
}
