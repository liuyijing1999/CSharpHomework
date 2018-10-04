using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class AlarmEventArgs:EventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }
    public delegate void AlarmEventHandler(object sender, AlarmEventArgs args);
    public class Alarmer
    {
        public event AlarmEventHandler Run;
        public void DoAlarm(int hour,int minute,int second)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            while (hour != DateTime.Now.Hour || minute != DateTime.Now.Minute || second != DateTime.Now.Second)
            {
               
            }
            AlarmEventArgs args = new AlarmEventArgs();
            args.Hour = hour;
            args.Minute = minute;
            args.Second = second;
            Run(this, args);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("当前时间:" + DateTime.Now.Hour+":"+ DateTime.Now.Minute+":"+ DateTime.Now.Second);
            string s = "";
            int hour = 0;
            int minute = 0;
            int second = 0;
            Console.Write("hour:");
            s = Console.ReadLine();
            hour = Int32.Parse(s);
            Console.Write("minute:");
            s = Console.ReadLine();
            minute = Int32.Parse(s);
            Console.Write("second:");
            s = Console.ReadLine();
            second = Int32.Parse(s);
            var Alarmer = new Alarmer();
            Alarmer.Run += ShowProgress;
            Alarmer.DoAlarm(hour,minute,second);
        }
        static void ShowProgress(object sender,AlarmEventArgs args)
        {
            Console.WriteLine("时间到了,当前时间为" + args.Hour + ":" + args.Minute + ":" + args.Second);
        }
    }
}
