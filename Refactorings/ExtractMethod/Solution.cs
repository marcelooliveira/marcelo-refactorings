using System;
using System.Collections.Generic;
using System.Text;

namespace Refactorings.ExtractMethod
{
    //Move this code to a separate new method (or function) and 
    //replace the old code with a call to the method.
    class Solution
    {
        string name;

        void PrintOwing()
        {
            PrintBanner();
            PrintDetails(GetOutstanding());
        }

        void PrintDetails(double outstanding)
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("amount: " + outstanding);
        }

        void PrintBanner()
        {

        }

        double GetOutstanding()
        {
            return 0d;
        }
    }
}


//Why Refactor

//The more lines found in a method, the harder it is to figure 
//out what the method does.This is the main reason for 
//this refactoring.

//Besides eliminating rough edges in your code, extracting methods 
//is also a step in many other refactoring approaches.

//Benefits

//More readable code! Be sure to give the new method a name that
//describes the method's purpose: createOrder(), renderCustomerInfo(), etc.
//Less code duplication.Often the code that is found in a method 
//can be reused in other places in your program.So you can replace
//duplicates with calls to your new method.
//Isolates independent parts of code, meaning that errors are less 
//likely(such as if the wrong variable is modified).
//How to Refactor

//Create a new method and name it in a way that makes its purpose 
//self-evident.
//Copy the relevant code fragment to your new method.Delete the fragment
//from its old location and put a call for the new method there instead.
//Find all variables used in this code fragment. If they are declared 
//inside the fragment and not used outside of it, simply leave 
//them unchanged – they will become local variables for the new method.

//If the variables are declared prior to the code that you are
//extracting, you will need to pass these variables to the 
//parameters of your new method in order to use the values previously 
//contained in them.Sometimes it is easier to get rid of these 
//variables by resorting to Replace Temp with Query.
//If you see that a local variable changes in your extracted code 
//in some way, this may mean that this changed value will
//be needed later in your main method.Double-check! And if 
//this is indeed the case, return the value of this variable 
//to the main method to keep everything functioning.