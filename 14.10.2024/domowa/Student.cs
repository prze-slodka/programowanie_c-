using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDomowe
{
    public class Student : HumanOnMS
    {
        public float Average { get; set; }

        public Student(float average, string beer_name) : base ( beer_name)
        {
            Average = average;
        }
    }
}
