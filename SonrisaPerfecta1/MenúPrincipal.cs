using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonrisaPerfecta1
{
    public partial class MenúPrincipal : Form
    {
        public MenúPrincipal()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAGENDACITAS_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar este formulario
            AgendamientoCitas form = new AgendamientoCitas(); //cargar Form3
            form.ShowDialog();//mostrar Form3
        }

        private void btnPACIENTES_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar este formulario
            DatosPersonalesPacientes form = new DatosPersonalesPacientes(); //cargar Form4
            form.ShowDialog();//mostrar Form4
        }

        private void btnTRATAMIENTOS_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar este formulario
            Tratamientos form = new Tratamientos(); //cargar Form4
            form.ShowDialog();//mostrar Form5
        }

        private void btnPROMOCIONES_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar este formulario
            Presupuestos form = new Presupuestos(); //cargar Form6
            form.ShowDialog();//mostrar Form6
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
