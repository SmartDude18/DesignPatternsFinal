using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models
{
    public interface ITimezone
    {
        //needs distinct versioning based on the timezone. this does two things
        // - run the distinct format
        // - shift the time over

        //ideas for implementation
        //UTC
        //mountain standard
        //central

        public bool isAlarmTime(DateTime currentUTC, DateTime alarmTime);
    }
}
