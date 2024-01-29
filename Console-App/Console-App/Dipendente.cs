using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Dipendente
    {
        private string _name;
        private string _work;
        private int _salary;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Work
        {
            get
            {
                return _work;
            }
            set
            {
                _work = value;
            }
        }

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }

        public string Introduce()
        {
            return "Hi!, I am " + this._name + " and I work as a " + this._work + " for " + this._salary.ToString() + "£";
        }
    }
}
