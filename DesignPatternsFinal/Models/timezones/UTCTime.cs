using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models.timezones
{
    public class UTCTime : ITimezone
    {
        public bool isAlarmTime(DateTime currentUTCTime, DateTime alarmTime)
        {
            return (currentUTCTime.Minute == alarmTime.Minute) && (currentUTCTime.Hour == alarmTime.Hour);
        }
    }
}
