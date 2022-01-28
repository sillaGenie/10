using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            int gradus = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec); 
            Console.WriteLine(angle.ToRadians(gradus, min, sec));
        }
       
    }
    class Angle
    {
        private int gradus;
        private int min;
        private int sec;

        public Angle(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public int Gragus
        {
            get { return gradus; }
            set { if (value >=0 && value<=360)
                gradus = value; }
        }
        public int Min {
            get { return min; }
            set { if (value >= 0 && value <= 60)
                    min = value;
            }
        }
        public int Sec
        {
            get
            { return sec; }
            set
            {
                if (value >= 0 && value >= 30)
                    sec = value;
            }
        }
        public double ToRadians(int g, int m, int s)
        {
            return g*Math.PI/180+m/60*Math.PI/180+s/360*Math.PI/180;
        }
    }
}