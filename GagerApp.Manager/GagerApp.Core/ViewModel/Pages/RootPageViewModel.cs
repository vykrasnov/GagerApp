using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Calcium;
using Calcium.Messaging;
using Calcium.Services;
using Calcium.UIModel;
using Calcium.UIModel.Input;
using GagerApp.Core.Services;
using GagerApp.Core.Utils;
using GagerApp.Core.ViewModel.Messages;
using GagerApp.Model.DTO;
using GagerApp.Model.Entities;

namespace GagerApp.Core.ViewModel.Pages
{
    public class RootPageViewModel : PageViewModel,
        IMessageSubscriber<OrderStatusUpdatedMessage>
    {

        #region Fields

        private readonly ActionCommand _profileCommand;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private IEnumerable<OrderDTO> _orders;
        private bool _isBusy;
        private string _username;

        #endregion Fields

        #region Constructors/Finalizers

        public RootPageViewModel(IUserService userService, IOrderService orderService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
            _profileCommand = new ActionCommand(OpenProfile);
            _ = InitAsync();
            OrderClickCommand = new ActionCommand<OrderDTO>(OpenOrderPage);
        }

        #endregion Constructors/Finalizers

        #region Properties/Indexers

        public bool IsBusy
        {
            get => _isBusy;
            private set => Set(ref _isBusy, value);
        }

        public ICommand ProfileCommand => _profileCommand;

        public IEnumerable<OrderDTO> Orders
        {
            get => _orders;
            private set => Set(ref _orders, value);
        }

        public string Username
        {
            //FIXME: This is a duct-tape, needs to be removed!!!
            get => string.IsNullOrWhiteSpace(_username) ? "Пользователь Тестовый 1" : _username;
            private set => Set(ref _username, value);
        }

        public ICommand OrderClickCommand
        {
            get;
        }

        #endregion Properties/Indexers

        #region Methods/Events

        private void OpenOrderPage(OrderDTO viewModel)
        {
            OrderPageViewModel.GetNavigationTokenFor<OrderPageViewModel>().NavigateToDestinationWith(viewModel.Number);
        }

        private void OpenProfile(object obj)
        {
            ProfilePageViewModel.GetNavigationTokenFor<ProfilePageViewModel>().NavigateToDestination();

        }

        private async Task InitAsync()
        {
            IsBusy = true;

            await UpdateOrdersAsync();
            await UpdateUserAsync();

            IsBusy = false;
        }

        private async Task UpdateUserAsync()
        {
            Username = await _userService.GetUserFIOAsync();
        }

        private async Task UpdateOrdersAsync()
        {
            IEnumerable<OrderDTO> ordersModel = await _orderService.GetOrdersAsync();
            var unsortedOrders = new ObservableCollection<OrderDTO>(ordersModel);
            var sortedOrders = new ObservableSortedCollection<OrderDTO>(unsortedOrders);
            sortedOrders.SortByPropertyName(nameof(OrderDTO.StartTime), false);
            Orders = sortedOrders;
        }

        Task IMessageSubscriber<OrderStatusUpdatedMessage>.ReceiveMessageAsync(OrderStatusUpdatedMessage message)
        {
            var order = Orders?.FirstOrDefault((o) => o.Number == message.OrderNumber);
            if (order != default)
            {
                order.Status = message.OrderStatus;
            }

            return Task.FromResult<object>(null);
        }

        #endregion Methods/Events
    }
}
