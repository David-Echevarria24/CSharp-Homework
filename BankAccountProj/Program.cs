using BankAccountProj;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = UserInterface.CreateAccount();
        UserInterface.ShowMenu(account);
    }
}