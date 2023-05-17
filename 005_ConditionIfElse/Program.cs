Console.WriteLine("Enter your name.");
string username = Console.ReadLine();

if (username.ToLower() == "masha") {
    Console.WriteLine("I love you, Masha!");
} else {
    Console.WriteLine("Hello, " + username);
}