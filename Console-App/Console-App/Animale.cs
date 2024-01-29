using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Animale
    {
        private string _name;
        private string _species;
        private string _color;

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

        public string Species
        {
            get
            {
                return _species;
            }
            set
            {
                _species = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public string Talk()
        {
            if (_species == "Cat")
            {
                return "Miao miao";
            }
            if (_species == "Dog")
            {
                return "Bau bau";
            }
            if (_species == "Sheep")
            {
                return "Beeee";
            }
            else
            {
                return "What does the " + this._species + "say?";
            }
        }
    }
}
