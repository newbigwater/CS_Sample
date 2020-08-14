using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AlarmHistory.Annotations;

namespace AlarmHistory
{
    public class AlarmHistorySchema : INotifyPropertyChanged
    {
        private int? _Unit;
        private string _Category;
        private DateTime _ReceivedTime;
        private int? _AlarmCode;
        private string _AlarmHexCode;
        private string _AlarmTextKorean;
        private string _AlarmTextChinese;
        private int? _Count;
        
        public int? Unit
        {
            get
            {
                return this._Unit;
            }
            set
            {
                if ((this._Unit != value))
                {
                    this._Unit = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                if ((this._Category != value))
                {
                    this._Category = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime ReceivedTime
        {
            get
            {
                return this._ReceivedTime;
            }
            set
            {
                if ((this._ReceivedTime != value))
                {
                    this._ReceivedTime = value;
                    OnPropertyChanged();
                }
            }
        }
        public int? AlarmCode
        {
            get
            {
                return this._AlarmCode;
            }
            set
            {
                if ((this._AlarmCode != value))
                {
                    this._AlarmCode = value;
                    OnPropertyChanged();
                }
            }
        }

        public string AlarmHexCode
        {
            get
            {
                return this._AlarmHexCode;
            }
            set
            {
                if ((this._AlarmHexCode != value))
                {
                    this._AlarmHexCode = value;
                    OnPropertyChanged();
                }
            }
        }
        public string AlarmTextKorean
        {
            get
            {
                return this._AlarmTextKorean;
            }
            set
            {
                if ((this._AlarmTextKorean != value))
                {
                    this._AlarmTextKorean = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public string AlarmTextChinese
        {
            get
            {
                return this._AlarmTextChinese;
            }
            set
            {
                if ((this._AlarmTextChinese != value))
                {
                    this._AlarmTextChinese = value;
                    OnPropertyChanged();
                }
            }
        }

        public int? Count
        {
            get
            {
                return this._Count;
            }
            set
            {
                if ((this._Count != value))
                {
                    this._Count = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class TableColumnSchema : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this._name = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
