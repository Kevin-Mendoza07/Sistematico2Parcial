using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public interface IService<T>
    {
        void Create(T t);
        T[] FindAll();
    }
}
