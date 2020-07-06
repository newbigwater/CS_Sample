using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress
{
    public class Sample: INotifyPropertyChanged
    {
        private string _name;
        private string _phone;
        private int _old;
        private bool _married;

        public int Old
        {
            get
            {
                return this._old;
            }

            set
            {
                if (value != this._old)
                {
                    this._old = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool Married
        {
            get
            {
                return this._married;
            }

            set
            {
                if (value != this._married)
                {
                    this._married = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                if (value != this._name)
                {
                    this._name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Phone
        {
            get
            {
                return this._phone;
            }

            set
            {
                if (value != this._phone)
                {
                    this._phone = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
