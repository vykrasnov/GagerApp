using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;

namespace GagerApp.Manager.Dummy
{
    public class DummyPartnerPageViewModel: ViewModelBase
    {
        public DummyPartnerPageViewModel()
        {
           
            GagerPartner = new ObservableCollection<PartnerDTO>()
            {
                new PartnerDTO()
                {
                   ClientDTO =  "Криптов Василий Васильевич",
                   TelefonNumber = "+ 7 912 783 32 23",
                   Type = "Физическое лицо" ,
                   AdressDTO =  "Барнаул, Попанцева, дом 23а, кв. 134"
                },
               new PartnerDTO()
                {
                   ClientDTO = "Абрамов Василий Аркадьевич",
                   TelefonNumber = "+ 7 932 783 42 23",
                   Type = "Юридичекое лицо" ,
                   AdressDTO ="Барнаул, Красноармейски проспект,дом 123",
                   NameCompany = "ООО СКАЙЛАЙН",
                   FullNameCompany = "Общество с ограниченной ответсвтенностю Скайлайн",
                   INN = 322322342
                   
                   
                },
                new PartnerDTO()
                {
                   ClientDTO = "Ковалёв Генадий Владимирович",
                   TelefonNumber = "+ 7 312 123 41 23",
                   Type = "Физическое лицо" ,
                   AdressDTO ="Барнаул,ул. Гоголя,дом 12",
                },
               new PartnerDTO()
                {
               ClientDTO = "Воронов Иван Петрович",
                   TelefonNumber = "+ 7 912 774 00 00",
                   Type = "Физическое лицо" ,
                   AdressDTO = "Барнаул, Беляева, 12, Кв. 14"
                }
              };

        }

        private IEnumerable<PartnerDTO> _gagerPartner;

        public IEnumerable<PartnerDTO> GagerPartner
        {
            get => _gagerPartner;
            private set => Set(ref _gagerPartner, value);
        }
       
    }
}
