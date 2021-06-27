using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using GagerApp.Core.Services;
using GagerApp.Model.DTO;
using GagerApp.Model.Entities;
using System.Linq;

namespace GagerApp.Core.ViewModel.Pages
{
    public class RoomPageViewModel : PageViewModel<int>
    {
        #region Fields

        private readonly int _roomNumber;
        private readonly IRoomPageService _roomPageService;
        private readonly IRoomService _roomService;
        private ObservableCollection<DopUslugaDTO> _dopUslugas;
        private bool _isBusy = false;
        private double _sum;

        #endregion Fields

        #region Constructors/Finalizers

        public RoomPageViewModel(int roomNumber, IRoomPageService roomPageService, IRoomService roomService) : base(roomNumber)
        {
            _roomNumber = roomNumber;
            _roomService = roomService ?? throw new ArgumentNullException(nameof(roomService));
            _roomPageService = roomPageService ?? throw new ArgumentNullException(nameof(roomPageService));
            _ = GetRoomPageModel();
        }

        #endregion Constructors/Finalizers

        #region Properties/Indexers

        public ObservableCollection<DopUslugaDTO> DopUslugas
        {
            get => _dopUslugas; private set => Set(ref _dopUslugas, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            private set => Set(ref _isBusy, value);
        }

        public FullRoomDTO Room
        {
            get;
            private set;
        }

        public double Sum
        {
            get => _sum;
            private set => Set(ref _sum, value);
        }

        #endregion Properties/Indexers

        #region Methods/Events

        private async Task GetRoomPageModel()
        {
            IsBusy = true;

            Room = await _roomService.GetFullRoomAsync(_roomNumber);
#if DEBUG
            _dopUslugas = new ObservableCollection<DopUslugaDTO>()
            {
                new DopUslugaDTODebug() { ID=1, Name="Светильник 20см", Col=4, Type="материал", Unit="шт", Price = "1000 руб." },
                new DopUslugaDTODebug() { ID=2, Name="Гардина (монтаж)", Col=1, Type="услуга", Unit="шт", Price = "200 руб." },
                new DopUslugaDTODebug() { ID=3, Name="Белое полотно «Тектум» (мат) с установкой до 3,5м без шва", Col=20, Type="материал", Unit="кв.м.", Price="10000 руб." },
                new DopUslugaDTODebug() { ID=4, Name="Вставка белая с установкой", Col=18, Type="материал", Unit="м", Price="900 руб." },
                new DopUslugaDTODebug() { ID=5, Name="Гардина, 3 м.", Col=1, Type="материал", Unit="шт", Price="1500 руб." },
            };
            _dopUslugas = new ObservableCollection<DopUslugaDTO>(_dopUslugas.OrderBy((dto) => dto.Name));

            Sum = 13600;
#else
            _dopUslugas = new ObservableCollection<DopUslugaDTO>(Room.DopUsluga);
#endif
            IsBusy = false;
            OnPropertyChanged(nameof(Room));
            OnPropertyChanged(nameof(DopUslugas));

        }

        #endregion Methods/Events

#if DEBUG
        private class DopUslugaDTODebug : DopUslugaDTO
        {

            public string Price
            {
                get;
                set;
            }

        }
#endif
    }
}
