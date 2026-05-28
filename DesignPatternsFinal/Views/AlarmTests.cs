using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsFinal.Controllers;
using DesignPatternsFinal.Models;
using DesignPatternsFinal.Models.alarms;
using DesignPatternsFinal.Models.timezones;

namespace DesignPatternsFinal.Views
{
    public class AlarmTests
    {
        public void runTests()
        {
            IAlarm testAlarm1 = new FiggleAlarm(new CentralTime(), (DateTime.UtcNow).AddMinutes(1).AddHours(-6), "Minute Console Test");
            IAlarm testAlarm2 = new ConsoleAlarm(new MountainTime(), (DateTime.UtcNow).AddMinutes(2).AddHours(-7), "Minute Console Test");

            WorldClock worldClock = WorldClock.getInstance();

            worldClock.addAlarm(testAlarm1);
            worldClock.addAlarm(testAlarm2);

            worldClock.alignTiming();

            while (true) { }
        }
    }
}
