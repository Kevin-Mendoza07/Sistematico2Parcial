using AppCore.Services;
using Domain.Entities;
using Infraestructura.ActivosFijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistematicoActivo.Forms
{
    public partial class FrmGestionActivo : Form
    {
        private ActivoFijoModel activoFijomodel;

        private IActivoFijoService activoFijoService;

        public FrmGestionActivo(IActivoFijoService activoFijoService)
        {
            this.activoFijoService = activoFijoService;

            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmActivo frmActivo = new FrmActivo();
            frmActivo.AService = activoFijoService;
            frmActivo.ShowDialog();
            Print();
            Dispose();

        }

        private void Print()
        {
            ActivoFijo[] activoFijos = activoFijomodel.FindAll();
            if (activoFijos == null)
            {
                rtbViewActivo.Text = "Esta vacia la lista de activos";
                return;
            }
            string text = string.Format("{0,5:d} {1,-20} {2,-15} {3,5:f} {4,-30:d} {5,4:d} \n", "Id", "Codigo", "Nombre", "Valor", "Fecha Adquisicion", "Tipo Activo");
            rtbViewActivo.Text = text;

            //MetodoDepreciacion procesoDepreciacion = new ProcesoDepreciacion();
            //foreach (ActivoFijo af in activoFijos)
            //{
            //    rtbDepre.AppendText(af.ToString());
            //    rtbDepre.AppendText($"{Environment.NewLine}");
            //}
        }
    }
}
