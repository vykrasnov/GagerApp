using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;

namespace GagerApp.Manager.Dummy
{
    public class DummyMyDayPageViewModel : ViewModelBase
    {
        public DummyMyDayPageViewModel()
        {
            GagerOrderFromSite = new ObservableCollection<OrderFromSiteDTO>()
            {
                new OrderFromSiteDTO()
                {
                    Time =  new DateTime(2021, 05, 01, 12, 00, 00),
                    Sum = 3022.21f,
                    Number = "+8(999) 175 22 33",
                    Name = "Любовь Семеновна Ляхова"
                },
                 new OrderFromSiteDTO()
                {
                    Time =  new DateTime(2021, 05, 01, 13, 00, 00),
                    Sum = 32222.21f,
                    Number = "+8(999) 475 22 31",
                    Name = "Людмила Аркадьевна Модкова"
                },
                  new OrderFromSiteDTO()
                {
                    Time =  new DateTime(2021, 05, 01, 17, 00, 00),
                    Sum = 12232.21f,
                    Number = "+8(999) 242 22 33",
                    Name = "Дмитрий Акакевич Сурков"
                }
            };
            GagerLastPayments = new ObservableCollection<LatePaymentsDTO>()
            {
                new LatePaymentsDTO()
                {
                    Date =  new DateTime(2021, 05, 30, 12, 00, 00),
                    Sum = 1222.21f, 
                    TelefonNumber = "+8(999) 475 22 83",
                    Name = "Аркадьев А.А."
                },
                 new LatePaymentsDTO()
                {
                    Date =  new DateTime(2021, 05, 30, 16, 00, 00),
                    Sum = 14322.21f,
                    TelefonNumber = "+8(999) 475 26 33",
                    Name = "Панасенко Г.А."
                },
                new LatePaymentsDTO()
                {
                    Date =  new DateTime(2021, 05, 29, 13, 00, 00),
                    Sum = 12322.21f,
                    TelefonNumber = "+8(923) 435 33 11",
                    Name = "Лужков К.А."
                },
                 new LatePaymentsDTO()
                {
                    Date =  new DateTime(2021, 05, 29, 15, 00, 00),
                    Sum = 1422.21f,
                    TelefonNumber = "+8(913) 435 73 11",
                    Name = "Ляхов К.А."
                },
                 new LatePaymentsDTO()
                {
                    Date =  new DateTime(2021, 05, 29, 15, 00, 00),
                    Sum = 1422.21f,
                    TelefonNumber = "+8(913) 435 73 11",
                    Name = "Ляхов К.А."
                },
                  new LatePaymentsDTO()
                {
                    Date =  new DateTime(2021, 05, 30, 12, 00, 00),
                    Sum = 10332.21f,
                    TelefonNumber = "+8(999) 475 12 33",
                    Name = "Панасенко Г.А."
                }
            };
            GagerOrders = new ObservableCollection<OrderDTO>()
            {
                new OrderDTO()
                {
                    Type = "Замер",
                    Address = "г.Барнаул, ул. Германа Титова, 2, кв 24",
                    StartTime = new DateTime(2021, 05, 01, 14, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 15, 00, 00),
                    Number = 102,
                      Name = "Анисимов А.А.",
                    Status = Model.Entities.OrderStatus.Pending
                },
                new OrderDTO()
                {

                     Type = "Замер",
                    Address = "г.Барнаул, ул. Деповская, д. 17 кв. 23 ",
                    StartTime = new DateTime(2021, 05, 01, 15, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 16, 00, 00),
                    Number = 103,
                    Name = "Белкин Б.Б.",
                    Status = Model.Entities.OrderStatus.Confirmed
                },
                new OrderDTO()
                {
                     Type = "Монтаж",
                    Address = "г.Барнаул, ул. Ломоносова, д. 2, кв 21",
                    StartTime = new DateTime(2021, 05, 01, 09, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 13, 00, 00),
                    Number = 104,
                      Name = "Кошкин В.А",
                    Status = Model.Entities.OrderStatus.Pending
                },
                new OrderDTO()
                {
                     Type = "Замер",
                    Address = "г.Барнаул, ул. Гагарина, д. 32, кв 124",
                    StartTime = new DateTime(2021, 05, 01, 10, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 13, 00, 00),
                    Number = 105,
                      Name = "Васнецов В.В.",
                    Status = Model.Entities.OrderStatus.Confirmed
                },
                new OrderDTO()
                {
                     Type = "Монтаж",
                    Address = "г.Барнаул, ул. Космонавтов, д. 43, кв 224",
                    StartTime = new DateTime(2021, 05, 01, 13, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 13, 00, 00),
                    Number = 106,
                    Name = "Дацик М.А",
                    Status = Model.Entities.OrderStatus.Pending
                },
                new OrderDTO()
                {
                     Type = "Замер",
                    Address = "г.Барнаул, ул. Демитрова, д. 1",
                    StartTime = new DateTime(2021, 05, 01, 09, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 13, 00, 00),
                    Number = 107,
                      Name = "Гранкин Г.Г.",
                    Status = Model.Entities.OrderStatus.Rejected
                },
                new OrderDTO()
                {
                     Type = "Монтаж",
                    Address = "г.Барнаул, ул. Славы Мерлоу, д. 44, кв 14",
                    StartTime = new DateTime(2021, 05, 01, 15, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 16, 00, 00),
                    Number = 108,
                      Name = "Тишкин В.А",
                    Status = Model.Entities.OrderStatus.Pending
                },
                new OrderDTO()
                {
                     Type = "Замер",
                    Address = "г.Барнаул, ул. Гагарина, д. 30, кв 65",
                    StartTime = new DateTime(2021, 05, 01, 16, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 17, 00, 00),
                    Number = 109,
                    Name = "Дьяченко Д.Д.",
                    Status = Model.Entities.OrderStatus.Pending
                },
                new OrderDTO()
                {
                     Type = "Монтаж",
                    Address = "г.Барнаул, ул. Ладыгина, д. 28, кв 90",
                    StartTime = new DateTime(2021, 05, 01, 19, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 20, 00, 00),
                    Number = 110,
                      Name = "Жамбалов В.А",
                    Status = Model.Entities.OrderStatus.Pending
                },
                new OrderDTO()
                {
                     Type = "Замер",
                    Address = "г.Барнаул, пр. Ленина, д 35, кв 233",
                    StartTime = new DateTime(2021, 05, 01, 18, 00, 00),
                    FinishTime = new DateTime(2021, 05, 01, 19, 00, 00),
                    Number = 111,
                      Name = "Ермолаев Е.Е",
                    Status = Model.Entities.OrderStatus.Pending
                }
            };
        }

        private IEnumerable<OrderDTO> _gagerOrders;
         private IEnumerable<LatePaymentsDTO> _gagerLastPayments;
        private IEnumerable<OrderFromSiteDTO> _gagerOrderFromSite;

        public IEnumerable<OrderDTO> GagerOrders
        {
            get => _gagerOrders;
            private set => Set(ref _gagerOrders, value);
        }

        public IEnumerable<OrderFromSiteDTO> GagerOrderFromSite
        {
            get => _gagerOrderFromSite;
            private set => Set(ref _gagerOrderFromSite, value);
        }
        public IEnumerable<LatePaymentsDTO> GagerLastPayments
        {
            get => _gagerLastPayments;
            private set => Set(ref _gagerLastPayments, value);
        }

    }
}
