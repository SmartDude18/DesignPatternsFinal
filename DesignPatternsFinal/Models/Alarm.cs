using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models
{
    internal interface Alarm
    {
        public void newMinute(DateTime newTime);
    }
}
