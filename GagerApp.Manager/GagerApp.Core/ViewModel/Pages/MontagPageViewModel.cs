using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Calcium.Services;
using Calcium.UIModel.Input;
using GagerApp.Core.Services;
using GagerApp.Core.Utils;
using GagerApp.Core.ViewModel.Messages;
using GagerApp.Model.DTO;
using TomsToolbox.ObservableCollections;

namespace GagerApp.Core.ViewModel.Pages
{
    public class MontagPageViewModel : PageViewModel<int>
    {

        #region Fields

        private readonly INavigationService _navigationService;
        private readonly int _orderNumber;
        private readonly IOrderPageService _orderPageService;
        private readonly IRoomService _roomService;
        private FullOrderDTO _fullOrder;
        private bool _isBusy;

        private ObservableCollection<RoomDTO> _rooms;

        private ObservableWrappedCollection<RoomDTO, RoomViewModel> _roomViewModels;

        private ObservableSortedCollection<RoomViewModel> _sortedRooms;

        #endregion Fields

        #region Constructors/Finalizers

        public MontagPageViewModel(int orderNumber, IOrderPageService orderPageService, IRoomService roomService, INavigationService navigationService) : base(orderNumber)
        {
            _orderPageService = orderPageService ?? throw new ArgumentNullException(nameof(orderPageService));
            _roomService = roomService ?? throw new ArgumentNullException(nameof(roomService));
            _navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
            _orderNumber = orderNumber;
            AcceptCommand = new ActionCommand(AcceptMontag, CanAcceptMontag);
            SelectRoomsCommand = new ActionCommand(OpenSelectRoomsPage, CanOpenSelectRoomsPage);
            SelectDateTimeCommand = new ActionCommand(OpenSelectDateTimePage, CanOpenSelectDateTimePage);
            _ = GetOrderPageModelAsync();
            _ = UpdateRooms();
        }

        #endregion Constructors/Finalizers

        #region Properties/Indexers

        public ICommand AcceptCommand
        {
            get;
        }

        public AdressDTO Adress => FullOrder?.Adress;

        public ClientDTO Client => FullOrder?.Client;

        public bool IsBusy
        {
            get => _isBusy;
            private set => Set(ref _isBusy, value);
        }

        public int? Number => FullOrder?.Number;

        public IEnumerable<RoomViewModel> Rooms => _sortedRooms;

        public ICommand SelectDateTimeCommand
        {
            get;
        }

        public ICommand SelectRoomsCommand
        {
            get;
        }

        private FullOrderDTO FullOrder
        {
            get => _fullOrder;
            set
            {
                if (Set(ref _fullOrder, value) == Calcium.ComponentModel.AssignmentResult.Success)
                {
                    OnPropertyChanged(nameof(Number));
                    OnPropertyChanged(nameof(Client));
                    OnPropertyChanged(nameof(Adress));
                }
            }
        }

        #endregion Properties/Indexers

        #region Methods/Events

        private void AcceptMontag(object obj)
        {
            //FIXME: Rewrite this, it's a duct-tape
            Messenger.PublishAsync<MontagAcceptedMessage>(new MontagAcceptedMessage(this, _orderNumber));
            _navigationService.GoBack();
        }

        private bool CanAcceptMontag(object arg)
        {
            return true;
        }

        private bool CanOpenSelectDateTimePage(object arg)
        {
            //TODO: implement proper check
            return true;
        }

        private bool CanOpenSelectRoomsPage(object arg)
        {
            //TODO: implement proper check
            return true;
        }

        private RoomViewModel CreateRoomViewModel(RoomDTO arg)
        {
            return new RoomViewModel(arg, _roomService);
        }

        private async Task GetOrderPageModelAsync()
        {
            IsBusy = true;
            FullOrder = await _orderPageService.GetFullOrderAsync(_orderNumber);
            IsBusy = false;
        }

        private void Item_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(RoomViewModel.Cost))
            {
                //TODO: Recalculate sum
            }
        }

        private void OpenSelectDateTimePage(object obj)
        {
            SelectMontagDateTimePageViewModel.GetNavigationTokenFor<SelectMontagDateTimePageViewModel>().NavigateToDestination();
        }

        private void OpenSelectRoomsPage(object obj)
        {
            SelectRoomsPageViewModel.GetNavigationTokenFor<SelectRoomsPageViewModel>().NavigateToDestinationWith(_orderNumber);
        }

        private void RoomViewModels_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    foreach (var item in e.NewItems.Cast<RoomViewModel>())
                    {
                        item.PropertyChanged += Item_PropertyChanged;
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    foreach (var item in e.OldItems.Cast<RoomViewModel>())
                    {
                        item.PropertyChanged -= Item_PropertyChanged;
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    foreach (var item in e.NewItems.Cast<RoomViewModel>())
                    {
                        item.PropertyChanged += Item_PropertyChanged;
                    }
                    foreach (var item in e.OldItems.Cast<RoomViewModel>())
                    {
                        item.PropertyChanged -= Item_PropertyChanged;
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    SubscribeAllItems(_sortedRooms);
                    break;
                default:
                    break;
            }
        }

        private void SubscribeAllItems(IEnumerable<RoomViewModel> roomViewModels)
        {
            foreach (var item in roomViewModels)
            {
                item.PropertyChanged -= Item_PropertyChanged;
                item.PropertyChanged += Item_PropertyChanged;
            }
        }

        private async Task UpdateRooms()
        {
            //TODO: Separate IsBusy
            IsBusy = true;
            var roomsModel = await _roomService.GetRoomsAsync(_orderNumber);

            _rooms = new ObservableCollection<RoomDTO>(roomsModel);

            _roomViewModels = new ObservableWrappedCollection<RoomDTO, RoomViewModel>(_rooms, CreateRoomViewModel);

            _sortedRooms = new ObservableSortedCollection<RoomViewModel>(_roomViewModels);
            _sortedRooms.SortByPropertyName(nameof(RoomViewModel.NameRoom), false);
            _sortedRooms.CollectionChanged += RoomViewModels_CollectionChanged;
            SubscribeAllItems(_sortedRooms);

            IsBusy = false;
            OnPropertyChanged(nameof(Rooms));
        }

        #endregion Methods/Events

    }
}
