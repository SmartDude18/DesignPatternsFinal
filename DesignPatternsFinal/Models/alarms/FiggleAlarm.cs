using Figgle.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models.alarms
{
    public class FiggleAlarm : IAlarm
    {
        private ITimezone timezone;
        private DateTime alarmTime;
        private string alarmName;
        public FiggleAlarm(ITimezone timezone, DateTime alarmTime, string alarmName)
        {
            this.timezone = timezone;
            this.alarmTime = alarmTime;
            this.alarmName = alarmName;
        }
        public void newMinute(DateTime newTime)
        {
            if (timezone.isAlarmTime(newTime, alarmTime))
            {
                Console.WriteLine(FiggleFonts.Standard.Render("ALARM: " + alarmName));
                //Console.WriteLine("ALARM: " + alarmName);
            }
        }


    }
}
