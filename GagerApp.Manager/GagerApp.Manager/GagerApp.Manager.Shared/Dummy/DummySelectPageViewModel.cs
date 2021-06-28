using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;
namespace GagerApp.Manager.Dummy
{
    public class DummySelectPageViewModel : ViewModelBase
    {
        public DummySelectPageViewModel()
        {
            GagerMaterial = new ObservableCollection<MaterialValuesDTO>()
            {
                new MaterialValuesDTO()
                {
                   Name = "Белое полотно «Тектум» (мат) с установкой до 3,5м без шва",
                  
                   Price = 350,
                   Col = 630,
                   Type = "М.кв"
                },
               new MaterialValuesDTO()
                {
                   Name = "Белое полотно «Тектум» (мат) с установкой от 3,5м до 5,5м без шва",
                  
                   Price = 280,
                   Col = 1430,
                   Type = "М.кв"
                },
               new MaterialValuesDTO()
                {
                   Name = "Полотно фактурное цветное № 225 (мат) с установкой, до 3,8м без шва",

                   Price = 380,
                   Col = 1030,
                   Type = "М.кв"
                },
               new MaterialValuesDTO()
                {
                   Name = "Светильник (монтаж) ШВВП",

                   Price = 2100,
                   Col = 100,
                   Type = "Шт."
                },
                  new MaterialValuesDTO()
                {
                   Name = "Пульт 2К с установкой",
                   Price = 980,
                   Col = 130,
                   Type = "М.кв"
                },
                   new MaterialValuesDTO()
                {
                   Name = "Конструкция из профиля ПФ7320 (линия FLEXY 5см, жёсткая заглушка) с двумя диодными лентами 18W (24V)",

                   Price = 200,
                   Col = 1020,
                   Type = "Шт."
                },
               new MaterialValuesDTO()
                {
                   Name = "Цветное полотно (мат, сатин) с установкой, до 3,8м без шва",
                 
                   Price = 400,
                   Col = 1322,
                   Type = "М.кв"
                }
              };

        }
        private IEnumerable<MaterialValuesDTO> _gagerMaterials;

        public IEnumerable<MaterialValuesDTO> GagerMaterial
        {
            get => _gagerMaterials;
            private set => Set(ref _gagerMaterials, value);
        }
    }
}
