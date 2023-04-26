using System;

namespace AnalogClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analog Clock Angle Calculator\n");
            
            // 1-12 only for the hour hand, greater than this will result to negative degrees
            Console.Write("Enter the hour (1-12): ");
            int hour = int.Parse(Console.ReadLine());

            // 0-59 only for the minute hand, greater than this will result to negative degress even if the hour hand is between 1-12
            Console.Write("Enter the minute (0-59): ");
            int minute = int.Parse(Console.ReadLine());

            // Calculate the angles in degrees of the hour and minute hands
            // Formula for computing hourAngle = 0.5 * (60 * hour + minute); 0.5 because the hour hand moves 30 degrees in 1 hour or 0.5 degrees per minute 
            double hourAngle = 0.5 * (60 * hour + minute);

            // Formula for computing minuteAngle = 6 * minute; 6 because the minute hand moves 360 degrees in 60 minutes or 6 per minute
            double minuteAngle = 6 * minute;

            // Calculate the absolute difference between the two angles
            double angleDiff = Math.Abs(hourAngle - minuteAngle);

            // Take the lesser angle between the two possible angles
            angleDiff = Math.Min(angleDiff, 360 - angleDiff);

            // Output the result to the console window
            Console.WriteLine($"The time is {hour} : {minute}");
            Console.WriteLine($"The lesser angle between the hour and minute hands is {angleDiff} degrees.");
        }
    }
}
