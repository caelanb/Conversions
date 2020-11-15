using System;
namespace Conversions
{
    public class Name
    {

        //holds the value of the first name
        private String firstName;

        //Alternate constructor, sets first name
        // if no parameters are given for a variable, the variable defaults to a null string
        public Name(String fName)
        {
            firstName = fName;
        }

        //Default constructor, sets first name to a null string
        public Name()
        {
            firstName = "";
        }

        //Function returns the first name of the individual
        public String getName()
        {
            return firstName;
        }

        //Function sets the first name value to firstName.
        // if no parameters are given.. the name defaults to a null string
        public void setName(String fName)
        {
            firstName = fName;
        }

        //Function prints the user's name to the screen
        public void Print()
        {
            Console.Write(firstName);
        }

        //
        ~Name()
        {
            Console.Write("I'm in the destructor for Name");
        }

    }
}
