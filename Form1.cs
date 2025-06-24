using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestorGastosApp
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public int ObtenerNumeroRandom(int minimo, int maximo)
        {
            return rnd.Next(minimo, maximo + 1);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        // Lista Gastos en memoria
        List<Gasto> gastos = new List<Gasto>();

        // El botón Agregar Gasto deberá agregar el gasto en la lista en memoria
        // y en la lista visible validando que se completen los datos en el formato que corresponda
        // y mostrando mensaje en caso de error. 
        // Luego de agregar con éxito el gasto, se limpiaran los campos.
        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            AgregarGasto();
            LimpiarGrupoABM();
        }

        private void LimpiarGrupoABM()
        {
            txtMonto.Clear();
            txtDescripcion.Clear();
            dtpFecha.Value = DateTime.Now;
            cmbCategoria.SelectedIndex = -1;
        }
        private void AgregarGasto()
        {
            string errores = "";
            errores += ValidarVacio(txtMonto.Text, "Monto");
            errores += ValidarNumPositivo(txtMonto.Text, "Monto", out int Monto);
            //errores += ValidarFecha(txtFecha.Text, "Fecha", out DateTime Fecha);
            errores += ValidarVacio(txtDescripcion.Text, "Descripción");
            errores += ValidarVacio(cmbCategoria.Text, "Desplegable Categoría");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error de carga");
            }
            else
            {
                Gasto gasto = new Gasto(Monto, cmbCategoria.Text, dtpFecha.Value, txtDescripcion.Text);
              
                gastos.Add(gasto);
                lstGastos.Items.Add(gasto.ToString());

            }
        }

        private string ValidarVacio(string cadena, string campo)
        {
            string msj = "";
            if (string.IsNullOrEmpty(cadena))
            {
                msj = $"Error en el campo {campo}: No podés dejarlo sin completar" + Environment.NewLine;
            }
            return msj;
        }

        private string ValidarNumPositivo(string entrada, string campo, out int salida)
        {
            string msj = "";
            if (!int.TryParse(entrada, out salida))
            {
                msj = $"Error en el campo {campo}: Debés ingresar un valor numérico" + Environment.NewLine;
            }
            else if (salida <= 0)
            {
                msj = $"Error en el campo {campo}: Debés ingresar un valor positivo" + Environment.NewLine;
            }
            return msj;
        }

        private string ValidarFecha(string entrada, string campo, out DateTime salida)
        {
            string msj = "";
            if (!DateTime.TryParse(entrada, out salida))
            {
                msj = $"Error en el campo {campo}: Debés ingresar una fecha" + Environment.NewLine;
            }
            return msj;
        }



        // El botón eliminara el gasto de la lista en memoria y de la lista visible,
        // validando que el usuario haya seleccionado uno de los gastos del listado de últimos gastos.
        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            EliminarGasto();
        }
        private void EliminarGasto()
        {
            string errores = "";
            errores = ValidarVacio(lstGastos.Text, "Lista últimos gastos");

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Error: Debés seleccionar un gasto del listado para poder eliminarlo");
            }
            else
            {
                string[] vector = lstGastos.Text.Split('-');
                // vector[0] = ID

                Gasto eliminar = BuscarGasto(int.Parse(vector[0]));
                gastos.Remove(eliminar);
                
                lstGastos.Items.RemoveAt(lstGastos.SelectedIndex);
            }
        }

        
        private void lstGastos_Click(object sender, EventArgs e)
        {
            

        }

        private Gasto BuscarGasto(int Identificacion)
        {
            return gastos.Find(g => g.ID == Identificacion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbCategoria.Items.Add("Alimentación");
            cmbCategoria.Items.Add("Vivienda");
            cmbCategoria.Items.Add("Salud");
            cmbCategoria.Items.Add("Educación");
            cmbCategoria.Items.Add("Impuestos");
            cmbCategoria.Items.Add("Servicios");
            cmbCategoria.Items.Add("Transporte");
            cmbCategoria.Items.Add("Ocio");
            cmbCategoria.Items.Add("Indumentaria");
            cmbCategoria.Items.Add("Tecnología");
            cmbCategoria.Items.Add("Otros");

            cmbCategoriaFiltrado.Items.Add("Todos");
            cmbCategoriaFiltrado.Items.Add("Alimentación");
            cmbCategoriaFiltrado.Items.Add("Vivienda");
            cmbCategoriaFiltrado.Items.Add("Salud");
            cmbCategoriaFiltrado.Items.Add("Educación");
            cmbCategoriaFiltrado.Items.Add("Impuestos");
            cmbCategoriaFiltrado.Items.Add("Servicios");
            cmbCategoriaFiltrado.Items.Add("Transporte");
            cmbCategoriaFiltrado.Items.Add("Ocio");
            cmbCategoriaFiltrado.Items.Add("Indumentaria");
            cmbCategoriaFiltrado.Items.Add("Tecnología");
            cmbCategoriaFiltrado.Items.Add("Otros");
            
            
            // Carga de gastos
            CargarGastos();


        }
        
        private void CargarGastos()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gastos.txt");

            FileInfo fi = new FileInfo(path);

            if (!fi.Exists)
            {
                MessageBox.Show("No se encontró el archivo en el directorio" + Environment.NewLine + path, "Error de Carga");
            }
            else
            {
                StreamReader sr = fi.OpenText();
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');
                    Gasto gasto = new Gasto();
                    // {ID};{Fecha};{Monto};{Categoria};{Descripcion}
                    gasto.ID = int.Parse(vector[0]);
                    gasto.Fecha = DateTime.Parse(vector[1]);
                    gasto.Monto = float.Parse(vector[2]);
                    gasto.Categoria = vector[3];
                    gasto.Descripcion = vector[4];
                    gastos.Add(gasto);
                    lstGastos.Items.Add(gasto.ToString());
                }
                sr.Close();
                MessageBox.Show("Se cargó con éxito el archivo");
            }
        }

        // Mostrar lo seleccionado por el usuario en listbox
        private void lstGastos_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstGastos.SelectedItem != null)
            {
                string[] vector = lstGastos.Text.Split('-');
                Gasto gasto = BuscarGasto(int.Parse(vector[0]));

                txtMonto.Text = gasto.Monto.ToString();
                txtDescripcion.Text = gasto.Descripcion;
                dtpFecha.Value = gasto.Fecha;
                cmbCategoria.Text = gasto.Categoria.ToString();
            }
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarGrupoABM();
        }

        // Funciona, pero aumenta el ID por cada modificación
        private void btnModificarGasto_Click(object sender, EventArgs e)
        {
            if(lstGastos.SelectedIndex != -1)
            {
                string[] vector = lstGastos.Text.Split('-');
                Gasto modificar = BuscarGasto(int.Parse(vector[0]));
                gastos.Remove(modificar);
                lstGastos.Items.RemoveAt(lstGastos.SelectedIndex);
                AgregarGasto();
                
            }
            else
            {
                MessageBox.Show("Error: Debe seleccionar un item de la lista a modificar");
            }
        }
        

        private void lstGastos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lstGastos.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string msj = "";
            float total = 0;
            if ((cmbCategoriaFiltrado.SelectedIndex == -1 || cmbCategoriaFiltrado.Text == "Todos") 
                && 
                string.IsNullOrEmpty(txtDescripcionFiltrado.Text)) 
            {
                List<Gasto> gastosbuscados = gastos.FindAll(g => g.Fecha.Date >= dtpDesde.Value.Date && g.Fecha.Date <= dtpHasta.Value.Date);
                if (gastosbuscados.Count <= 0)
                {
                    msj = "No se encontraron gastos con los filtros elegidos";
                    MessageBox.Show(msj);
                }
                else
                {   
                    foreach (Gasto gastobuscado in gastosbuscados)
                    {
                        msj += gastobuscado.ToString() + Environment.NewLine;
                        string[] vector = gastobuscado.ToString().Split('-');
                        Gasto gastito = BuscarGasto(int.Parse(vector[0]));

                        total += gastito.Monto;
                    }
                    //MessageBox.Show($"Total Gastado:"  + Environment.NewLine + $"${total}"  + Environment.NewLine + "Detalle: " + Environment.NewLine + msj);
                    gastosbuscados = gastosbuscados.OrderByDescending(g => g.Fecha).ThenBy(g => g.Monto).ToList();
                    Resultados ventana = new Resultados(gastosbuscados, total, dtpDesde.Value, dtpHasta.Value);
                    ventana.ShowDialog(); // Bloquea hasta que se cierre

                }

            }
            else if (string.IsNullOrEmpty(txtDescripcionFiltrado.Text))
            {
                List<Gasto> gastosbuscados = gastos.FindAll(g => g.Fecha.Date >= dtpDesde.Value.Date && g.Fecha.Date <= dtpHasta.Value.Date 
                && g.Categoria == cmbCategoriaFiltrado.Text);
                
                if (gastosbuscados.Count <= 0)
                {
                    msj = "No se encontraron gastos con los filtros elegidos";
                    MessageBox.Show(msj);
                }
                else
                {
                    foreach (Gasto gastobuscado in gastosbuscados)
                    {
                        msj += gastobuscado.ToString() + Environment.NewLine;
                        string[] vector = gastobuscado.ToString().Split('-');
                        Gasto gastito = BuscarGasto(int.Parse(vector[0]));

                        total += gastito.Monto;
                        
                    }
                    //MessageBox.Show($"Total Gastado en {cmbCategoriaFiltrado.Text}: " + Environment.NewLine +  $"${total} " + Environment.NewLine + "Detalle: " + Environment.NewLine + msj);
                    gastosbuscados = gastosbuscados.OrderByDescending(g => g.Fecha).ThenBy(g => g.Monto).ToList();
                    Resultados ventana = new Resultados(gastosbuscados, total, dtpDesde.Value, dtpHasta.Value);
                    ventana.ShowDialog(); // Bloquea hasta que se cierre
                    
                }
            }
            else if ((cmbCategoriaFiltrado.SelectedIndex == -1 || cmbCategoriaFiltrado.Text == "Todos") && !string.IsNullOrEmpty(txtDescripcionFiltrado.Text))
            {
                string descripcion = txtDescripcionFiltrado.Text.ToLower();
                List<Gasto> gastosbuscados = gastos.FindAll(g => g.Fecha.Date >= dtpDesde.Value.Date && g.Fecha.Date <= dtpHasta.Value.Date
                 && g.Descripcion.ToLower().Contains(descripcion));
                if (gastosbuscados.Count <= 0)
                {
                    msj = "No se encontraron gastos con los filtros elegidos";
                    MessageBox.Show(msj);
                }
                else
                {
                    foreach (Gasto gastobuscado in gastosbuscados)
                    {
                        msj += gastobuscado.ToString() + Environment.NewLine;
                        string[] vector = gastobuscado.ToString().Split('-');
                        Gasto gastito = BuscarGasto(int.Parse(vector[0]));

                        total += gastito.Monto;
                    }
                    //MessageBox.Show($"Total Gastado en {txtDescripcionFiltrado.Text.ToUpper()}:" + Environment.NewLine + $"${total}" + Environment.NewLine + "Detalle: " + Environment.NewLine + msj);
                    gastosbuscados = gastosbuscados.OrderByDescending(g => g.Fecha).ThenBy(g => g.Monto).ToList();
                    Resultados ventana = new Resultados(gastosbuscados, total, dtpDesde.Value, dtpHasta.Value);
                    ventana.ShowDialog(); // Bloquea hasta que se cierre

                }
            }
            else
            {
                string descripcion = txtDescripcionFiltrado.Text.ToLower();
                List<Gasto> gastosbuscados = gastos.FindAll(g => g.Fecha.Date >= dtpDesde.Value.Date && g.Fecha.Date <= dtpHasta.Value.Date
                && g.Categoria == cmbCategoriaFiltrado.Text && g.Descripcion.ToLower().Contains(descripcion));
                if (gastosbuscados.Count <= 0)
                {
                    msj = "No se encontraron gastos con los filtros elegidos";
                    MessageBox.Show(msj);
                }
                else
                {
                    foreach (Gasto gastobuscado in gastosbuscados)
                    {
                        msj += gastobuscado.ToString() + Environment.NewLine;
                        string[] vector = gastobuscado.ToString().Split('-');
                        Gasto gastito = BuscarGasto(int.Parse(vector[0]));

                        total += gastito.Monto;
                    }
                    //MessageBox.Show($"Total gastado en {cmbCategoriaFiltrado.Text}: ${total} " + Environment.NewLine + "DETALLE: " + Environment.NewLine + msj);
                    gastosbuscados = gastosbuscados.OrderByDescending(g => g.Fecha).ThenBy(g => g.Monto).ToList();
                    Resultados ventana = new Resultados(gastosbuscados, total, dtpDesde.Value, dtpHasta.Value);
                    ventana.ShowDialog(); // Bloquea hasta que se cierre

                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuardarGastos();
        }

        private void GuardarGastos()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gastos.txt");

            FileInfo fi = new FileInfo(path);

            StreamWriter sw = new StreamWriter(path);
            foreach (Gasto g in gastos)
            {
                sw.WriteLine(g.Format());
            }
            sw.Close();
            MessageBox.Show("Se guardaron los datos");
        }
    }
}