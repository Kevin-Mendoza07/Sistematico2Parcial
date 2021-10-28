using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructura.ActivosFijos;
using SistematicoActivo.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoActivo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ActivoFijoModel>().As<IActivoFijoModel>();
            builder.RegisterType<ActivoFijoService>().As<IActivoFijoService>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmGestionActivo(container.Resolve<IActivoFijoService>()));
        }
    }
}
