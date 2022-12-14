using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._2console
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _mobilePhone;
        private int _workPhone;
        private string _address;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public int MobilePhone { get { return _mobilePhone; } set { _mobilePhone = value; } }
        public int WorkPhone { get { return _workPhone; } set { _workPhone = value; } }
        public string Address { get { return _address; } set { _address = value; } }

        public Person(string fName, string lName, int mobile, int work, string addr)
        {
            _firstName = fName;
            _lastName = lName;
            _mobilePhone = mobile;
            _workPhone = work;
            _address = addr;
        }

    }
}
