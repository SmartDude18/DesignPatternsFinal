using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal.Models
{
    public interface IAlarm
    {
        public void newMinute(DateTime newTime);
        //ideas for instances

        //repeating (runs and doesnt remove itself from the observer)

        //terminating (runs and then removes itself from the observer)
    }
}
