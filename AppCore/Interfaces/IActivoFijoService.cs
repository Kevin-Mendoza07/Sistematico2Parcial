using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public interface IActivoFijoService:IService<ActivoFijo>
    {
        int GetLastId();
    }
}
