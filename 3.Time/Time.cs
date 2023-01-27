namespace _3.Time
{
    public class Time
    {
        private byte hours;
        private byte minutes;
        private byte seconds;
        public byte Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException("Hours must be between 0 and 23");
                }

                hours = value;
            }
        }
        public byte Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException("Minutes must be between 0 and 59");
                }

                minutes = value;
            }
        }
        public byte Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException("Seconds must be between 0 and 59");
                }

                seconds = value;
            }
        }

        public Time(byte hours, byte minutes, byte seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Time() { }

        public override string ToString()
        {
            return $"{this.Hours:D2}:{this.Minutes:D2}:{this.Seconds:D2}";
        }
    }
}
