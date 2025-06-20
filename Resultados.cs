using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorGastosApp
{
    public partial class Resultados : Form
    {
        public Resultados(List<Gasto> gastosbuscados, float total, DateTime fechaDesde, DateTime fechaHasta)
        {
            InitializeComponent();
            dgvResultados.DataSource = gastosbuscados;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 👉 Formato de columnas
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResultados.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (dgvResultados.Columns.Contains("Fecha"))
                dgvResultados.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgvResultados.Columns.Contains("Monto"))
                dgvResultados.Columns["Monto"].DefaultCellStyle.Format = "C2";

            if (dgvResultados.Columns.Contains("ID"))
                dgvResultados.Columns["ID"].Visible = false;

            // 👉 Estilo visual
            dgvResultados.Font = new Font("Segoe UI", 10);
            dgvResultados.DefaultCellStyle.BackColor = Color.White;
            dgvResultados.DefaultCellStyle.ForeColor = Color.Black;
            dgvResultados.GridColor = Color.LightGray;

            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvResultados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvResultados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);


            lblResultados.Text = $"Total gastado: ${total:N2}";
            lblfecha1.Text = fechaDesde.ToString("dd/MM/yy");
            lblfecha2.Text = fechaHasta.ToString("dd/MM/yy");
        }
        public Resultados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
