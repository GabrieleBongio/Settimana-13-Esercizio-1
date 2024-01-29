using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    public class Atleta
    {
        private string _name;
        private string _sport;
        private string _nationality;

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
        public string Sport
        {
            get
            {
                return _sport;
            }
            set
            {
                _sport = value;
            }
        }
        public string Nationality
        {
            get
            {
                return _nationality;
            }
            set
            {
                _nationality = value;
            }
        }

        public string Introduce ()
        {
            return "Hi!, I am " + this._name + " and I play " + this._sport;
        }
    }
}
