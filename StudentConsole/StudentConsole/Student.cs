using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsole
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private double _avgpoint;

        public double AvgPoint
        {
            get { return _avgpoint; }
            set

            {
                if (value > 0 && value < 100)
                {
                    _avgpoint = value;

                }
            }
        }

        public Student()
        {
            
        }





    }
}
