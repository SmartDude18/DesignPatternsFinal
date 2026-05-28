using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models
{
    public class WorldClock
    {
        //https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=netframework-4.8.1
        private static WorldClock? instance;
        private DateTime currentDateTime;
        private Alarm[] recievers;
        //will have list of recievers when implementing observer

        private WorldClock(){}

        public WorldClock getInstance()
        {
            if(instance == null)
            {
                instance = new WorldClock();
            }
            return instance;
        }

        public void alignTiming()
        {
            //we likely are not aligned with the start of the minute when we start running, fix that
        }

        private void newMinute()
        {
            foreach(Alarm alarm in recievers)
            {
                alarm.newMinute(currentDateTime);
            }
            //new minute has passed, ping the observers
        }

        private void runUpdateLoop()
        {
            //we have aligned to the minute, now for the core timer loops
            //await Task.Delay(2000); - use instead of sleep for proper timing
            //60000 - number for a minute
        }




    }
}
