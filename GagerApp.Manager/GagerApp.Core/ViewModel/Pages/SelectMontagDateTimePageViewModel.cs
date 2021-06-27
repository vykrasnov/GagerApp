using System;
using System.Collections.Generic;
using System.Text;

namespace GagerApp.Core.ViewModel.Pages
{
    /// <summary>
    /// TODO: Finish this class. For now, it's a dummy
    /// </summary>
    public class SelectMontagDateTimePageViewModel : PageViewModel
    {
        public SelectMontagDateTimePageViewModel()
        {
        }

        public List<string> Hours { get; } = new List<string>()
        {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
        };

        public List<BrigadeSchedule> BrigadesTime
        {
            get;
        } = new List<BrigadeSchedule>()
        {
            new BrigadeSchedule()
            {
                Name = "Бригада 1",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, false, false, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 2",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 3",
                Hours = new List<bool>()
                { false, false, false, false, false, true, true, true, true, true, true, false, true, true, true, true, true, true, false, false, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 4",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 5",
                Hours = new List<bool>()
                { false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, false, false, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 6",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 7",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, false, false, true, true, true, true, false, true, true, true, true, true, true, true, true, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 8",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 9",
                Hours = new List<bool>()
                { false, false, false, false, false, false, true, true, true, true, false, false, true, true, true, true, true, true, true, true, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 10",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false,}
            },
            new BrigadeSchedule()
            {
                Name = "Бригада 11",
                Hours = new List<bool>()
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false,}
            }
        };


        public class BrigadeSchedule
        {
            public string Name
            {
                get;
                set;
            }

            public List<bool> Hours
            {
                get;
                set;
            }
        }
    }
}
