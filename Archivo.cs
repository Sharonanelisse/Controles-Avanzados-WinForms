using ControlesAvanzados.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAvanzados
{
    public partial class Archivo : Form
    {
        List<Venta> ventas = new List<Venta>();
        public Archivo()
        {
            InitializeComponent();
            agregarVentas();
            inicializarListBox();
            inicializarComboBoxAnios();
            inicializarComboBoxMeses();
        }

        private void agregarVentas()
        {
            ventas.Add(new Venta(2024, 1, "Guatemala", 100000));
            ventas.Add(new Venta(2024, 2, "Guatemala", 80000));
            ventas.Add(new Venta(2024, 3, "Guatemala", 95000));
            ventas.Add(new Venta(2024, 4, "Guatemala", 120000));
            ventas.Add(new Venta(2024, 5, "Guatemala", 100000));
            ventas.Add(new Venta(2024, 6, "Guatemala", 110000));
            ventas.Add(new Venta(2024, 1, "Jutiapa", 50000));
            ventas.Add(new Venta(2024, 2, "Jutiapa", 80000));
            ventas.Add(new Venta(2024, 3, "Jutiapa", 67000));
            ventas.Add(new Venta(2024, 4, "Jutiapa", 55000));
            ventas.Add(new Venta(2024, 5, "Jutiapa", 67000));
            ventas.Add(new Venta(2024, 6, "Jutiapa", 45000));
            ventas.Add(new Venta(2024, 1, "Chiquimula", 43000));
            ventas.Add(new Venta(2024, 2, "Chiquimula", 55000));
            ventas.Add(new Venta(2024, 3, "Chiquimula", 23000));
            ventas.Add(new Venta(2024, 4, "Chiquimula", 34000));
            ventas.Add(new Venta(2024, 5, "Chiquimula", 56000));
            ventas.Add(new Venta(2024, 6, "Chiquimula", 78000));
            ventas.Add(new Venta(2024, 1, "Escuintla", 86000));
            ventas.Add(new Venta(2024, 2, "Escuintla", 75000));
            ventas.Add(new Venta(2024, 3, "Escuintla", 64000));
            ventas.Add(new Venta(2024, 4, "Escuintla", 78000));
            ventas.Add(new Venta(2024, 5, "Escuintla", 79000));
            ventas.Add(new Venta(2024, 6, "Escuintla", 90000));
            ventas.Add(new Venta(2024, 6, "Zacapa", 10000));
        }

        private void mostrarVentas()
        {
            listadoVentas.Controls.Clear();

            /*
                Where es una función de LINQ que permite filtrar una lista de elementos, ejecuta una función 
                por cada elemento de la lista y si la función retorna true, el elemento es incluido en la lista resultante.
                Es útil para filtrar elementos de una lista que cumplan con ciertas condiciones.
                El formato de las funciones lambda es el siguiente: (elemento) => condición, si quisiera sustituirse podría usarse 
                una función anónima, con el formato delegate(bool nombreVariable) { return condición; } o una función normal.
            */
            
            List<Venta> ventasFiltradas = ventas
                .Where(venta => selectorDepartamento.SelectedItem == null || selectorDepartamento.SelectedItems.Contains(venta.Departamento))
                .Where(venta => venta.Anio == (int)comboBoxAnios.SelectedItem) //Una forma de hacer parseo seguro
                .Where(venta => venta.Mes == comboBoxMeses.SelectedIndex + 1).ToList();

            foreach (Venta venta in ventasFiltradas)
            {
                Label labelVenta = crearEqituetaVenta(venta);
                listadoVentas.Controls.Add(labelVenta);
            }
        }

        private void inicializarListBox()
        {
            List<string> departamentos = new List<string>();
            foreach (Venta venta in ventas)
            {
                if (!departamentos.Contains(venta.Departamento))
                {
                    departamentos.Add(venta.Departamento);
                }
            }
            foreach (string departamento in departamentos)
            {
                selectorDepartamento.Items.Add(departamento);
            }
        }

        private void inicializarComboBoxAnios()
        {
            List<int> anios = new List<int>();
            foreach (Venta venta in ventas)
            {
                if (!anios.Contains(venta.Anio))
                {
                    anios.Add(venta.Anio);
                }
            }
            foreach (int anio in anios)
            {
                comboBoxAnios.Items.Add(anio);
            }

            comboBoxAnios.SelectedIndex = 0;
        }

        private void inicializarComboBoxMeses()
        {
            List<string> meses = new List<string>();
            foreach (Venta venta in ventas)
            {
                string nombreMes = obtenerNombreMesPorNumero(venta.Mes);
                if (!meses.Contains(nombreMes))
                {
                    meses.Add(nombreMes);
                }
            }
            foreach (string mes in meses)
            {
                comboBoxMeses.Items.Add(mes);
            }

            comboBoxMeses.SelectedIndex = 0;
        }

        private string obtenerNombreMesPorNumero(int numeroMes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[numeroMes - 1];
        }

        private Label crearEqituetaVenta(Venta venta)
        {
            Label labelVenta = new Label();
            labelVenta.Text = $"Año: {venta.Anio} \n Mes: {venta.Mes} \n Departamento: {venta.Departamento} \n Ventas: Q.{venta.Ventas}";
            labelVenta.AutoSize = true;
            labelVenta.Font = new Font("Arial", 12, FontStyle.Bold);
            labelVenta.Padding = new Padding(10);
            labelVenta.BorderStyle = BorderStyle.FixedSingle;
            labelVenta.Margin = new Padding(10);
            labelVenta.BackColor = Color.LightGray;
            return labelVenta;
        }

        private void selectorDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void comboBoxAnios_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarVentas();
        }

        private void comboBoxMeses_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarVentas();
        }
    }
}
