using DesignPatternsFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Controllers
{
    public class WorldClock
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=netframework-4.8.1
        private static WorldClock? instance;
        private DateTime currentDateTime;
        private List<IAlarm> recievers;
        //will have list of recievers when implementing observer

        private WorldClock()
        {
            recievers = new List<IAlarm>();
        }

        public static WorldClock getInstance()
        {
            if(instance == null)
            {
                instance = new WorldClock();
            }
            return instance;
        }

        public async void alignTiming()
        {
            
            //we likely are not aligned with the start of the minute when we start running, fix that
            int currentMinute = (DateTime.UtcNow).Minute;
            while(true)
            {
                Console.WriteLine("Time Cycle");
                await Task.Delay(500);
                if(currentMinute != (DateTime.UtcNow).Minute)
                {
                    break;
                }
            }
            runUpdateLoop();
        }

        private void newMinute()
        {
            foreach(IAlarm alarm in recievers)
            {
                alarm.newMinute(currentDateTime);
            }
            //new minute has passed, ping the observers
        }

        private async void runUpdateLoop()
        {
            Console.WriteLine("Time Cycle");
            currentDateTime = DateTime.UtcNow;
            newMinute();
            Console.WriteLine("New Minute" + currentDateTime.ToString());
            await Task.Delay(60000);
            runUpdateLoop();
            //we have aligned to the minute, now for the core timer loops
            //await Task.Delay(2000); - use instead of sleep for proper timing
            //60000 - number for a minute
        }

        public void addAlarm(IAlarm alarm)
        {
            recievers.Add(alarm);
        }

        public void removeAlarm(IAlarm alarm)
        {
            recievers.Remove(alarm);
        }




    }
}
