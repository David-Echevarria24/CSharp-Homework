namespace RobotTracker;

class Program
{
    static void Main()
    {
        string modelName = "C3PO";
        if(Robot.IsModelAllowed(modelName))

        Robot Hillbot = new Robot("R2D2", 19);
        Robot Fillbot = new Robot("RX89A", 40);
        Robot Jillbot = new Robot("C3PO", 90);

    }
}


class Robot //Created a class
{
    string model;
    int batteryLevel;

    static int totalRobotsActivated;

    public Robot(string model, int batteryLevel) //Created a constrcutor
    {
        this.model = model;
        this.batteryLevel = batteryLevel;
        totalRobotsActivated++;
    }

    public void Recharge(int charged) // Method adds int to battery level(recharges battery)
    {
        batteryLevel += charged;

        if (batteryLevel >= 100)
        {
            batteryLevel = 100;
        }
        Console.WriteLine(batteryLevel);

    }

    public static int GetTotalActivated() //Created function for total
    {
        return totalRobotsActivated;

    }

    public bool NeedsRecharge()
    {
        return batteryLevel < 20;
        
    }
    public static bool IsModelAllowed(string modelName)
    {
        string toUpperName = modelName.ToUpper();
        return toUpperName.StartsWith("RX") && modelName.Length >= 5;
    }
}

