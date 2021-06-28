using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Calcium.UIModel;
using GagerApp.Model.DTO;

namespace GagerApp.Manager.Dummy
{
    public class DummyWorkerPageVIewModel : ViewModelBase
    {
        public DummyWorkerPageVIewModel()
        {
            GagerWorkers = new ObservableCollection<WorkerDTO>()
            {
                new WorkerDTO()
                {
                   Name = "Денисов А.Б.",
                   Number = 1 ,
                   StartTime = new DateTime(2021, 05, 01, 12, 00, 00),
                   Status = "Уволен",
                   
                   
                   
                   Type = "Менеджер"
                },
               new WorkerDTO()
                {
                   Name = "Балилый В.С.",
                   Number = 1 ,
                   StartTime = new DateTime(2021, 05, 01, 12, 00, 00),
                   Status = "Работает",



                   Type = "Директор"
               },
               new WorkerDTO()
                {
                   Name = "Сергиенко А.А.",
                   Number = 1 ,
                   StartTime = new DateTime(2021, 05, 01, 12, 00, 00),
                   Status = "Работает",



                   Type = "Замерщики" }
              };

        }


        private IEnumerable<WorkerDTO> _gagerWorkers;

    public IEnumerable<WorkerDTO> GagerWorkers
    {
        get => _gagerWorkers;
        private set => Set(ref _gagerWorkers, value);
    }
}
}

