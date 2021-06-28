using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;

namespace GagerApp.Manager.Dummy
{
    public class DummyNewPaartnerDialogViewModel : ViewModelBase
    {
        public DummyNewPaartnerDialogViewModel()
        {
            GagerClient = new ObservableCollection<ClientDTO>()
            {
                 new ClientDTO
                 {
                     NameClient = "Василий",
                     PaternumClient = "Васильевич",
                     SurnameClient = "Криптов"
                 },
                  new ClientDTO
                 {
                     NameClient = "Василий",
                     PaternumClient = "Аркадьевич",
                     SurnameClient = "Абрамов"
                 }

            };
            GagerTelefons = new ObservableCollection<TelefonDTO>()
            {
                new TelefonDTO()
                {
                    Telefon = "+ 7 (912)545-32-32"
                },
                new TelefonDTO()
                {
                    Telefon = "+ 7 (923)645-22-72"
                },
            };

        }
        private IEnumerable<TelefonDTO> _gagerTelefons;

        public IEnumerable<TelefonDTO> GagerTelefons
        {
            get => _gagerTelefons;
            private set => Set(ref _gagerTelefons, value);
        }
        private IEnumerable<ClientDTO> _gagerClient;

        public IEnumerable<ClientDTO> GagerClient
        {
            get => _gagerClient;
            private set => Set(ref _gagerClient, value);
        }
    }
}
