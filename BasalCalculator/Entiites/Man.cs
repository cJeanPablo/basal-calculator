using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasalCalculator.Entiites
{
    public class Man
    {
        public int age { get; set; }
        public double weight { get; set; }
        public int height { get; set; }

        public Man(int age, double weight, int height)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public int Calculator(int age, double weight, int height)
        {
            return (int)(66 + (13.7 * weight) + (5 * height) - (6.8 - age));
        }

    }
}
