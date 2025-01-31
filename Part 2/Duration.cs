using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03.Part_2
{
     class Duration
    {
        private int hours;
        private int minute;
        private int seconds;


        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Minutes
        {
            get { return minute; }
            set
            {
                minute = value;
                while (minute >= 60)
                {
                    hours += minute / 60;
                    minute = minute % 60;
                }
            }
        }
        public int Seconds
        {
            get { return seconds; }
            set
            {
                seconds = value; 
                 while (seconds >= 60)
                    {
                    minute += seconds / 60;
                    seconds = seconds % 60;
                }
                while (minute >= 60)
                {
                    hours += minute / 60;
                    minute = minute % 60;
                }
            }
        }
        public Duration(int hours, int minute, int seconds)
        {
            this.hours = hours;
            this.minute = minute;
            this.seconds = seconds;
        }
        public Duration()
        {
            hours = minute = seconds = 0;
        }
        public Duration(int seconds)
        {
            hours = seconds / 3600;
            minute = (seconds  % 3600) / 60;
            this.seconds = seconds % 60;
        }


        public override string ToString()
        {

            if (hours != 0)
            {
                return $"Hours={hours} , Minutes={minute}, Seconds ={seconds}";
            }
            else if (minute != 0)
            {
                return $"Minute={minute}, Seconds={seconds}";

            }
            else
            {
                return $"Seconds={seconds}";
            }

        }
      
        public override bool Equals(object? obj)
        {
            if (obj == null )  
                return false;
            Duration D = (Duration)obj;
            return hours == D.hours && minute == D.minute && seconds == D.seconds;
        }
        public override int GetHashCode()
        {
            return hours.GetHashCode() ^ minute.GetHashCode() ^ seconds.GetHashCode();
        }


        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(left.hours * 3600 + left.minute * 60 + left.seconds +
            right.hours * 3600 + right.minute * 60 + right.seconds);
        }
        public static Duration operator +(Duration left, int right)
        {
            return new Duration(left.hours * 3600 + left.minute * 60+left.seconds + right);
        }
        public static Duration operator +( int left, Duration right)
        {
            return new Duration(right.hours*3600+ right.minute*60+ right.seconds + left);
        }
        public static Duration operator ++(Duration left)
        {
            return new Duration(left.hours*3600+ left.minute*60+60+left.seconds);
        }

        public static Duration operator --(Duration left)
        {
            return new Duration(left.hours * 3600 + left.minute * 60 - 60 + left.seconds);
        }
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration((left.hours * 3600 + left.minute * 60 + left.seconds) - (right.hours * 3600 + right.minute * 60 + right.seconds)) ;
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.hours * 3600 + d1.minute * 60 + d1.seconds) >
                   (d2.hours * 3600 + d2.minute * 60 + d2.seconds);
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.hours * 3600 + d1.minute * 60 + d1.seconds) <
                   (d2.hours * 3600 + d2.minute * 60 + d2.seconds);
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return (d1.hours * 3600 + d1.minute * 60 + d1.seconds) <=
                   (d2.hours * 3600 + d2.minute * 60 + d2.seconds);
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return (d1.hours * 3600 + d1.minute * 60 + d1.seconds) >=
                   (d2.hours * 3600 + d2.minute * 60 + d2.seconds);
        }
        public static bool operator true(Duration d)
        {
            return (d.hours!= 0 && d.minute != 0 && d.seconds != 0);

        }
        public static bool operator false(Duration d)
        {
            return (d.hours == 0 && d.minute == 0 && d.seconds == 0);

        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(2025, 1, 27, d.hours,d.minute, d.seconds);
        }

    }
}
