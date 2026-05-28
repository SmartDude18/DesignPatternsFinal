using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models.alarms
{
   public class ConsoleAlarm : IAlarm
    {
        private ITimezone timezone;
        private DateTime alarmTime;
        private string alarmName;
        public ConsoleAlarm(ITimezone timezone, DateTime alarmTime, string alarmName)
        {
            this.timezone = timezone;
            this.alarmTime = alarmTime;
            this.alarmName = alarmName;
        }
        public void newMinute(DateTime newTime)
        {
            if (timezone.isAlarmTime(newTime, alarmTime))
            {
                Console.WriteLine("ALARM: " + alarmName);
            }
        }

        
    }
}
