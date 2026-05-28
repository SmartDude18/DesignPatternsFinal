using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models.timezones
{
    public class MountainTime : ITimezone
    {
        public bool isAlarmTime(DateTime currentUTC, DateTime alarmTime)
        {
            DateTime holdTime = currentUTC.AddHours(-7);
            return (holdTime.Minute == alarmTime.Minute) && (holdTime.Hour == alarmTime.Hour);
        }
    }
}
