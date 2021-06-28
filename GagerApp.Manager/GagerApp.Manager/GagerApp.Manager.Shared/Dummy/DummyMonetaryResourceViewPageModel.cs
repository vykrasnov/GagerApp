using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;

namespace GagerApp.Manager.Dummy
{
    public class DummyMonetaryResourceViewPageModel : ViewModelBase
    {
    
        public DummyMonetaryResourceViewPageModel()
    {
        GagerMonetary = new ObservableCollection<MonetaryResourceDTO>()
            {
                new MonetaryResourceDTO()
                {
                   Date =  new DateTime(2021, 05, 01, 12, 00, 00),
                   Type = "Приход",
                   Sum = 234234,
                   TypeMoney = "Полная оплата Натяжной потолок",
                   Name = "Вяткин В.С."
                },
                 new MonetaryResourceDTO()
                {
                   Date =  new DateTime(2021, 05, 01, 12, 00, 00),
                   Type = "Расход",
                   Sum = 234234,
                   TypeMoney = "Выплата заработной платы за Май",
                   Name = "Персонал"
                },
                new MonetaryResourceDTO()
                {
                   Date =  new DateTime(2021, 05, 10, 12, 00, 00),
                   Type = "Приход",
                   Sum = 3232,
                   TypeMoney = "Расрочка по платежу от 12.04.2021",
                   Name = "Сероткин В.С."
                },
              };

    }

    private IEnumerable<MonetaryResourceDTO> _gagermonetary;

    public IEnumerable<MonetaryResourceDTO> GagerMonetary
        {
        get => _gagermonetary;
        private set => Set(ref _gagermonetary, value);
    }
}
}
