using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlarmClock

{
    class Program
    {
        static void Main(string[] args)
        {

            IAlarmClock sveglia = new AlarmClock();

            sveglia.PowerOn();
            sveglia.Time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            sveglia.AlarmTime = new DateTime(2017, 10, 10, 11, 21, 30).ToString("yyyy/MM/dd HH:mm:ss");
            Console.WriteLine("premi un tasto per terminare");
            Console.ReadLine();

            sveglia.PowerOff();
        }
    }
}
