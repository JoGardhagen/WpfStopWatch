using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStopWatch
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;
        private int miliSecound;


        public Time(int hour, int minute, int second, int miliSecound)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.miliSecound = miliSecound;
        }
        public Time(string currentTime)
        {
            string[] time = currentTime.Split(":");
            hour = int.Parse(time[0]);
            minute = int.Parse(time[1]);
            second = int.Parse(time[2]);
            miliSecound = int.Parse(time[3]);

        }
        public string getCurrentTime()
        {
            return hour + ":" + minute + ":" + second + ":" + miliSecound;
        }
        public string timeReset(string currentTime)
        {
            string[] time = currentTime.Split(":");
            hour = int.Parse(time[0]);
            minute = int.Parse(time[1]);
            second = int.Parse(time[2]);
            miliSecound = int.Parse(time[3]);


            //hour = Integer.parseInt(time[0]);
            //minute = Integer.parseInt(time[1]);
            //second = Integer.parseInt(time[2]);
            hour = 0;
            minute = 0;
            second = 0;
            miliSecound = 0;
            return hour + ":" + minute + ":" + second + ":" + miliSecound;
        }
        public void oneSecondPassed()
        {
            miliSecound++;
            if (miliSecound == 10)
            {
                miliSecound = 0;
                second++;
                if (second == 60)
                {
                    minute++;
                    second = 0;
                    if (minute == 60)
                    {
                        hour++;
                        minute = 0;
                        if (hour == 24)
                        {
                            hour = 0;
                            Console.WriteLine("Next day");
                        }
                    }
                }
            }
        }
    }
}
