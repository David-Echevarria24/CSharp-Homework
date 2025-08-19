namespace CreateCalculator;

class Program
{
    static void Main(string[] args)
    {

        // Grades
        string letter = "A";
        string letter2 = "B";




        //  Sophia's grades and getting average
        string name1 = "Sophia";
        int sophiaGrade1 = 93;
        int sophiaGrade2 = 87;
        int sophiaGrade3 = 98;
        int sophiaGrade4 = 95;
        int sophiaGrade5 = 100;
        decimal sophiaAverage = (decimal)(sophiaGrade1 + sophiaGrade2 + sophiaGrade3 + sophiaGrade4 + sophiaGrade5) / 5;
        string sophiaDisplay = name1 + "\t" + (decimal)sophiaAverage + " " + letter;


        // Andrew's grades and getting average
        string name2 = "Andrew";
        int andrewGrade1 = 80;
        int andrewGrade2 = 83;
        int andrewGrade3 = 82;
        int andrewGrade4 = 88;
        int andrewGrade5 = 85;
        decimal andrewAverage = (decimal)(andrewGrade1 + andrewGrade2 + andrewGrade3 + andrewGrade4 + andrewGrade5) / 5;
        string andrewDisplay = name2 + "\t" + (decimal)andrewAverage + " " + letter2;

        // Emma's grades and getting average
        string name3 = "Emma";
        int emmaGrade1 = 84;
        int emmaGrade2 = 96;
        int emmaGrade3 = 73;
        int emmaGrade4 = 85;
        int emmaGrade5 = 79;
        decimal emmaAverage = (decimal)(emmaGrade1 + emmaGrade2 + emmaGrade3 + emmaGrade4 + emmaGrade5) / 5;
        string emmaDisplay = name3 + "\t" + (decimal)emmaAverage + " " + letter2;

        // Logan's grades and getting average
        string name4 = "Logan";
        int loganGrade1 = 90;
        int loganGrade2 = 92;
        int loganGrade3 = 98;
        int loganGrade4 = 100;
        int loganGrade5 = 97;
        decimal loganAverage = (decimal)(loganGrade1 + loganGrade2 + loganGrade3 + loganGrade4 + loganGrade5) / 5;
        string loganDisplay = name4 + "\t" + (decimal)loganAverage + " " + letter2;

        // Display grades
        Console.WriteLine("Student Grade");
        Console.WriteLine(sophiaDisplay);
        Console.WriteLine(andrewDisplay);
        Console.WriteLine(emmaDisplay);
        Console.WriteLine(loganDisplay);


    }
}
