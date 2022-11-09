using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._3winforms
{
    internal class Student
    {
        private int _id;
        private string _name;
        private double _GPA;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double GPA { get { return _GPA; } set { _GPA = value; } }

        public Student()
        {
            ID = 0;
            Name = "unknown";
            GPA = 0.0;
        }

        public Student(int id, string name, double gpa)
        {
            ID = id;
            Name = name;
            GPA = gpa;
            
        }
    }
}
