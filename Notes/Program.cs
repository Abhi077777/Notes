using System;

class Customer
{
    string _FN;
    string _LN;

    public Customer(string FirstName, string LastName) //here we create customer class constructor we can give the parameter to the constructor but cannot return typr.
    {
       this._FN = FirstName;  //this  keywrd refer to an instance of claas to an object of this class
       this._LN = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}",this._FN + " " + this._LN);
    }

    ~Customer() //Destructar dont hold anp parameter and return type only hold garbage value and clean up any resource of app.
    {
        //clean up ccode
    }
}
class Program
{
    public static void Main()
    {
        Customer C1 = new Customer("Abhishek", "Sharma");
        C1.PrintFullName();
    }
}