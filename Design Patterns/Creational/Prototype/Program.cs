namespace Prototype;

public class Program
{
    static void Main(string[] args)
    {
        Robot robot = new Robot("CK550", "White", DateTimeOffset.UtcNow, new IdInfo(1337));

        // Creates a shallow copy of the robot and assign it to shallowClone
        Robot shallowClone = robot.ShallowCopy();

        // Creates a deep copy of robot and assign it to deepClone
        Robot completeClone = robot.CompleteCopy();

        // Display values of original robot, shallow copy and complete copy
        Console.WriteLine("Original values of original robot, shallow copy and complete copy:");
        Console.WriteLine("   Original robot instance values: ");
        DisplayValues(robot);
        Console.WriteLine("   Shallow copy instance values:");
        DisplayValues(shallowClone);
        Console.WriteLine("   Complete copy instance values:");
        DisplayValues(completeClone);

        // Changing the the properties of the original robot and see the values of the coppies
        robot.Model = "MX550";
        robot.Color = "Black";
        robot.CreationDate = DateTimeOffset.UtcNow;
        robot.SerialNumber.IdNumber = 7777;

        Console.WriteLine("Values of original robot, shallow copy and complete copy after the change:");
        Console.WriteLine("   Original robot instance values: ");
        DisplayValues(robot);
        Console.WriteLine("   Shallow copy instance values:");
        DisplayValues(shallowClone);
        Console.WriteLine("   Complete copy instance values:");
        DisplayValues(completeClone);
    }

    private static void DisplayValues(Robot robot)
    {
        Console.WriteLine($"      Model: {robot.Model}, Color: {robot.Color}, CreationDate: {robot.CreationDate}");
        Console.WriteLine($"      ID#: {robot.SerialNumber.IdNumber}");
    }
}