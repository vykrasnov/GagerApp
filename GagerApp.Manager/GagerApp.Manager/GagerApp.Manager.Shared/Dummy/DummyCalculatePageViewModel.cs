using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;

namespace GagerApp.Manager.Dummy
{
    public class DummyCalculatePageViewModel: ViewModelBase
    {
        public DummyCalculatePageViewModel()
        {

            GagerCalculatePrice = new ObservableCollection<CalculatePriceDTO>()
            {

                new CalculatePriceDTO()
                {
                    Name = "Направляющая",
                    Col = "12 шт.",
                    Price = 68,
                    Sum = 920,
                   
                   
                },
                new CalculatePriceDTO()
                {
                     Name = "Подсветка",
                    Col = "16 м.",
                    Price = 430,
                    Sum = 5670,
                   
                },
            };
           
        }

  
        private IEnumerable<CalculatePriceDTO> _сalculatePrice;

        public IEnumerable<CalculatePriceDTO> GagerCalculatePrice
        {
            get => _сalculatePrice;
            private set => Set(ref _сalculatePrice, value);
        }

      

    }
}

