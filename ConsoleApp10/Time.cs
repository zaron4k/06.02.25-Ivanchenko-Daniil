using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;
        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public Time(int h)
        {
            hours = h;
            minutes = 0;
            seconds = 0;
        }
        public Time(int h, int m)
        {
            hours = h;
            minutes = m;
            seconds = 0;
        }
        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public int TotalMinutes()
        {
            return hours * 60 + minutes;
        }
        public int TotalSeconds()
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }
        public void SetTime(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public string GetTimeInfo()
        {
            return $"Время: {hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}
