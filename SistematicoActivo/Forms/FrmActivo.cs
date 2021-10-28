using AppCore.Services;
using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmActivo : Form
    {
        public ActivoFijoModel AModel { get; set; }
        public IActivoFijoService AService { get; set; }

        public FrmActivo()
        {
            InitializeComponent();
        }

        private void FrmActivo_Load(object sender, EventArgs e)
        {
            cmbTipoActivo.Items.AddRange(Enum.GetValues(typeof(TipoActivo)).Cast<Object>().ToArray());
            cmbTipoMetodo.Items.AddRange(Enum.GetValues(typeof(TipoMetodo)).Cast<Object>().ToArray());

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            ActivoFijo ac = new ActivoFijo()
            {
                Id = AService.GetLastId() + 1,
                CodigoActivo = txtCodigo.Text,
                NombreActivo=txtNombre.Text,
                Descripcion=txtDescripcion.Text,
                ValorActivo=nudValorActivo.Value,
                FechaAdquisicion=dtpFechaAdquisicion.Value,
                TipoActivo=(TipoActivo)cmbTipoActivo.SelectedIndex,
                TipoMetodo=(TipoMetodo)cmbTipoMetodo.SelectedIndex

            };
            AModel.Create(ac);
            Dispose();

        }
    }
}
