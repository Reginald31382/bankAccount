class Program
{
    //Application execution starts here

    static void Main()
    {
        //display title
        System.Console.WriteLine("**********Dixon Bank**********");
        System.Console.WriteLine("::Login::");

        //declare variables to store username and password
        string userName = null, password = null;

        //read userName from keyboard
        System.Console.WriteLine("Username: ");
        userName = System.Console.ReadLine();

        if (userName!="")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if(userName == "system"&& password == "manager")
        {
            System.Console.WriteLine("TO DO: Main menu here");
        }

        //about to exit
        System.Console.WriteLine("Thank you! Please visit again.");
        System.Console.ReadKey();
    }
}