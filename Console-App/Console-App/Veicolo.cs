using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Veicolo
    {
        private string _House;
        private string _Model;
        private int _Autonomy;
        private int _Kilometers = 0;
        private Boolean _IsStarted = false;

        public string House
        {
            get { return _House; }
            set { _House = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public int Autonomy
        {
            get { return _Autonomy; }
            set { _Autonomy = value; }
        }
        public string Start()
        {
            if (_IsStarted)
            {
                return "Already started";
            }
            else
            {
                _IsStarted = true;
                return "Started successfully";
            }
        }

        public string Stop()
        {
            if (!_IsStarted)
            {
                return "Already stopped";
            }
            else {
                _IsStarted = false;
                return "Stopped successfully";
            }
        }

        public string DriveFor(int number)
        {
            if (_IsStarted)
            { 
                if (number + _Kilometers > _Autonomy)
                {
                    return "You can only drive for " + (this._Autonomy - this._Kilometers).ToString() + "km";
                }
                else
                {
                    _Kilometers += number;
                    return "You arrive to your destination, now you have " + this._Kilometers.ToString() + "km, you can drive for " + (this._Autonomy - this._Kilometers).ToString() + "km before making a refill";
                }
            }
            else
            {
                return "The car is not started so it can't go anywhere";
            }
        }

        public string Refill()
        {
            if (!_IsStarted)
            {
                _Kilometers = 0;
                return "Refilled successfully";
            }
            else
            {
                return "The car is not stopped so it's risky to refill it";
            }
        }
    }
}
