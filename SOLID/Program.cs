// See https://aka.ms/new-console-template for more information
using SOLID;

Console.WriteLine("Hello, Welcome to X portal, Enter L to Login and R to Register");
var manager = new UserManager();

RegisterNewUser(manager);


static void RegisterNewUser(UserManager manager)
{
    var input = Console.ReadLine();
    while (true)
    {

        if( input == "R") {
        Console.Write("Enter the username: ");
        var userName = Console.ReadLine();
        Console.Write("Enter the password: ");
        var password = Console.ReadLine();
        string userId = Guid.NewGuid().ToString("N");
        manager.Register(userId, userName, password);
        var user = manager.GetDetails(userId); 
       
        Console.WriteLine($"User: {user}");
        Console.WriteLine("====================================");

        } else if( input == "L") {

        Console.Write("Enter the username: ");
        var userName = Console.ReadLine();
        Console.Write("Enter the password: ");
        var password = Console.ReadLine();
        string userId = Guid.NewGuid().ToString("N");
        manager.Login(userName, password);
        
        var user = manager.GetDetails(userId);
        Console.WriteLine($"User: {user}");
        Console.WriteLine("====================================");


        } else {

             Console.WriteLine("Try again !!!");
                break;
        }
    }
}

#region
//manager.Login("sarah", "admin");

//Console.WriteLine($"User: {user}");


//SOLID:

//S -> Single Responsibility: 
//Open-Close Principle
//L -> Liscov Substitution
//I -> Interface Segregation
//D -> Dependency Inversion of Control
#endregion

#region Assignment
// 1. Take user inpput to decide which action they want to perform (e.g r-to register, l for login)
// 2. Print User details each time user logs in
// 3. Separate users details use case into a single responsibility
// 4. Password length must not be less that 6 (registration & login)
#endregion

