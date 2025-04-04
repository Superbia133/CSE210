using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public override void Run()
    {
        Start();
        int time = GetDuration();
        while (time > 0)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            time -= 4;

            if (time <= 0) break;

            Console.Write("\nBreathe out... ");
            ShowCountdown(6);
            time -= 6;
        }
        End();
    }
}
