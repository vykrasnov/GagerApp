using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;

namespace GagerApp.Manager.Dummy
{
    public class DummyDateDialogViewModel : ViewModelBase
    {
        public DummyDateDialogViewModel()
        {
            DateRecords = new ObservableCollection<DateRecord>()
            {
                new DateRecord
                {
                    Time = "00:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "01:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "02:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "03:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "04:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "05:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "06:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "07:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "08:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "г.Барнаул, ул.Шумакова, д.10 кв.15", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "г.Барнаул, ул. Славы Мерлоу, д. 44, кв 14", IsTaken = true },
                    },
                },
                new DateRecord
                {
                    Time = "09:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "г.Барнаул, ул. Деповская, д. 17 кв. 23", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = true },
                    },
                },
                new DateRecord
                {
                    Time = "10:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "Барнаул, Красноармейски проспект,дом 123", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "11:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "г.Барнаул, ул. Демитрова, д. 232", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "12:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "13:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "г.Барнаул, пр. Ленина, д 35, кв 233", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "14:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "г.Барнаул, ул. Демитрова, д. 1", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "15:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = true },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "16:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "17:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "18:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "19:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "20:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "21:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "22:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
                new DateRecord
                {
                    Time = "23:00",
                    GagerRecords = new ObservableCollection<GagerRecord>()
                    {
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                        new GagerRecord() { Address = "", IsTaken = false },
                    },
                },
            };
        }

        public IEnumerable<DateRecord> DateRecords
        {
            get;
            private set;
        }

        public class DateRecord
        {
            public string Time
            {
                get;
                set;
            }

            public IEnumerable<GagerRecord> GagerRecords
            {
                get;
                set;
            }
        }

        public class GagerRecord : ViewModelBase
        {
            public string Address
            {
                get; set;
            } 

            public bool IsTaken
            {
                get; set;
            }
        }
    }
}
