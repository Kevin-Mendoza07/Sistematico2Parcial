using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class ActivoFijoService : IActivoFijoService
    {
        private IActivoFijoModel activoFijoModel;

        public ActivoFijoService(IActivoFijoModel activoFijoModel)
        {
            this.activoFijoModel = activoFijoModel;
        }

        public void Create(ActivoFijo t)
        {
            activoFijoModel.Create(t);
        }

        public ActivoFijo[] FindAll()
        {
            return activoFijoModel.FindAll();
        }

        public int GetLastId()
        {
            return activoFijoModel.GetLastId();
        }
    }
}
