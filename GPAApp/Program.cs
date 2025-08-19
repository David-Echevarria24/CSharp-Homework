namespace GPAApp;

class Program
{
    static void Main(string[] args)
    {
        string studentName = "Sophia Johnson";
        string courseDisplay = "Course\t\tGrade\tCredit Hours";

        string courseName1 = "English 101";
        string coursename2 = "Algebra 101";
        string courseName3 = "Biology 101";
        string courseName4 = "Computer Science I";
        string courseName5 = "Psychology 101";

        int gradeValue1 = 4;
        int gradeValue2 = 3;

        int creditHours1 = 4;
        int creditHours2 = 3;

        int courseSum1 = (gradeValue1 * creditHours2);
        int courseSum2 = (gradeValue2 * creditHours2);
        int courseSum3 = (gradeValue2 * creditHours1);
        int courseSum4 = (gradeValue2 * creditHours1);
        int courseSum5 = (gradeValue1 * creditHours2);

        int courseTotal = (courseSum1 + courseSum2 + courseSum3 + courseSum4 + courseSum5);
        int creditHoursSum = (creditHours2 + creditHours2 + creditHours1 + creditHours1 + creditHours2);
        decimal gpa = (decimal)(courseTotal) / (decimal)(creditHoursSum);


        Console.WriteLine("Student: " + studentName);
        Console.WriteLine(courseDisplay);
        Console.WriteLine(courseName1 + "\t" + gradeValue1 + "\t" + creditHours2);
        Console.WriteLine(coursename2 + "\t" + gradeValue2 + "\t" + creditHours2);
        Console.WriteLine(courseName3 + "\t" + gradeValue2 + "\t" + creditHours1);
        Console.WriteLine(courseName4 + "\t" + gradeValue2 + "\t" + creditHours1);
        Console.WriteLine(courseName5 + "\t" + gradeValue1 + "\t" +  creditHours2);
        Console.WriteLine("Final GPA:\t" + gpa.ToString("F2"));






    }
}
