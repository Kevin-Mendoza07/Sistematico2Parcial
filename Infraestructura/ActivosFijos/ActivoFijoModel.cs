using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.ActivosFijos
{
    public class ActivoFijoModel:IActivoFijoModel
    {
        private ActivoFijo[] activoFijos;

        public void Create(ActivoFijo ac, ref ActivoFijo[] cs)
        {
            if (cs == null)
            {
                cs = new ActivoFijo[1];
                cs[cs.Length - 1] = ac;
                return;

            }
            ActivoFijo[] tmp = new ActivoFijo[cs.Length + 1];
            Array.Copy(cs, tmp, cs.Length);
            tmp[tmp.Length - 1] = ac;
            cs = tmp;
        }

        public void Create(ActivoFijo t)
        {
            throw new NotImplementedException();
        }

        public ActivoFijo[] FindAll()
        {
            return activoFijos;
        }
        public int GetLastId()
        {
            return activoFijos == null ? 0 : activoFijos[activoFijos.Length - 1].Id;
        }
    }


    }

