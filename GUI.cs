using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Builder.Director;
using Builder.Models;
using Builder.Builder;

namespace Builder
{
    public partial class GUI : Form
    {
        Cocina _cocina;
        List<Hamburguesa> _hamburguesas = new List<Hamburguesa>();
        double _total;

        public GUI()
        {
            InitializeComponent();

            _cocina = new Cocina();
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            dataGridView1.Columns["StringIngredientes"].Width = 300;

            _total = 0.00;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            total.Text = _total.ToString();
        }

        private void angus_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new AngusBuilder(CarneEnum.Angus, PanEnum.Blando));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void arrachera_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
                eliminar.Enabled = true;

            _cocina.RecepcionarHamburguesa(new ArracheraBuilder(CarneEnum.Arrachera, PanEnum.Rustico));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void buffalo_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new BuffaloBuilder(CarneEnum.PolloEmpanizado, PanEnum.Cristal));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void empanizado_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new EmpanizadoBuilder(CarneEnum.PolloEmpanizado, PanEnum.Blando));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void kobe_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new KobeBuilder(CarneEnum.Kobe, PanEnum.Rustico));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void original_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new MolidaBuilder(CarneEnum.Molida, PanEnum.Blando));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void pescado_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new PescadoBuilder(CarneEnum.Pescado, PanEnum.Integral));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void pollo_Click(object sender, EventArgs e)
        {
            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _cocina.RecepcionarHamburguesa(new PolloBuilder(CarneEnum.Pollo, PanEnum.Cristal));
            _cocina.CocinarHamburguesaPasoAPaso();
            Hamburguesa hamburguesa = _cocina.HamburguesaPreparada;

            _hamburguesas.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Hamburguesa hamburguesa = _hamburguesas[dataGridView1.SelectedCells[0].RowIndex];
            _hamburguesas.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total -= hamburguesa.Costo;
            UpdateTotal();

            if (!_hamburguesas.Any())
            {
                eliminar.Enabled = false;
                pagar.Enabled = false;
            }
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            _hamburguesas.Clear();
            dataGridView1.DataSource = new BindingSource { DataSource = _hamburguesas };
            _total = 0;
            UpdateTotal();
            eliminar.Enabled = false;
            pagar.Enabled = false;
        }
    }
}
