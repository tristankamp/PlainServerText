using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class Car
    {
        private string _model;
        private string _color;
        private int _registrationNumber;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public Car(string model, string color, int registrationNumber)
        {
            _model = model;
            _color = color;
            _registrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return ($"Model: "+Model+" Color: "+Color+" Registrationnumber: "+RegistrationNumber);
        }
    }
}
