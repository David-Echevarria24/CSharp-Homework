namespace Do_WhileLoop1;

class Program
{


    static void Main(string[] args)
    {
        bool validNumber = false;
        string? readResult;
        string valueEntered = "";
        int numValue = 0;

        Console.WriteLine("Enter an integer value between 5 and 10");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                valueEntered = readResult;
            }

            validNumber = int.TryParse(valueEntered, out numValue);

            if (validNumber == true)
            {
                if (numValue < 5 || numValue > 10)
                {
                    validNumber = false;
                    Console.WriteLine($"You entered {numValue}. This needs to be between 5 and 10.");
                }
            }
            else
            {
                Console.WriteLine("Not an integer - try again.");
            }

        } while (validNumber == false);

        Console.WriteLine($"Your input value of {numValue} has been accepted");
    }
}
