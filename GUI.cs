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
        List<IComida> _comida = new List<IComida>();
        double _total;
        Plato _plato = null;

        public GUI()
        {
            InitializeComponent();

            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            dataGridView1.Columns["StringIngredientes"].Width = 300;
            dataGridView1.Columns["Foto"].Width = 35;
            ((DataGridViewImageColumn)dataGridView1.Columns["Foto"]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            _total = 0.00;
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            total.Text = _total.ToString();
        }

        private void angus_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new AngusBuilder(CarneEnum.Angus, PanEnum.Blando, angus.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void arrachera_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
                eliminar.Enabled = true;

            _plato = new ArracheraBuilder(CarneEnum.Arrachera, PanEnum.Rustico, arrachera.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void buffalo_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new BuffaloBuilder(CarneEnum.PolloEmpanizado, PanEnum.Cristal, buffalo.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void empanizado_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new EmpanizadoBuilder(CarneEnum.PolloEmpanizado, PanEnum.Blando, empanizado.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void kobe_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new KobeBuilder(CarneEnum.Kobe, PanEnum.Rustico, kobe.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void original_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new MolidaBuilder(CarneEnum.Molida, PanEnum.Blando, original.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void pescado_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new PescadoBuilder(CarneEnum.Pescado, PanEnum.Integral, pescado.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void pollo_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new PolloBuilder(CarneEnum.Pollo, PanEnum.Cristal, pollo.Image);
            IComida hamburguesa = _plato.PrepararPlato();

            _comida.Add(hamburguesa);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += hamburguesa.Costo;
            UpdateTotal();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            IComida comida = _comida[dataGridView1.SelectedCells[0].RowIndex];
            _comida.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total -= comida.Costo;
            UpdateTotal();

            if (!_comida.Any())
            {
                eliminar.Enabled = false;
                pagar.Enabled = false;
            }
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            _comida.Clear();
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total = 0;
            UpdateTotal();
            eliminar.Enabled = false;
            pagar.Enabled = false;

            MessageBox.Show("Cuenta pagada con éxito.");
        }

        private void albondigasB_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new AlbondigasBBuilder(CarneEnum.Molida, PanEnum.Rustico, albondigasB.Image);
            IComida baguette = _plato.PrepararPlato();

            _comida.Add(baguette);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += baguette.Costo;
            UpdateTotal();
        }

        private void jamonB_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new JamonBBuilder(CarneEnum.Nada, PanEnum.Cristal, jamonB.Image);
            IComida baguette = _plato.PrepararPlato();

            _comida.Add(baguette);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += baguette.Costo;
            UpdateTotal();
        }

        private void polloB_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new PolloBBuilder(CarneEnum.Pollo, PanEnum.Blando, polloB.Image);
            IComida baguette = _plato.PrepararPlato();

            _comida.Add(baguette);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += baguette.Costo;
            UpdateTotal();
        }

        private void salamiB_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new SalamiBBuilder(CarneEnum.Nada, PanEnum.Integral, salamiB.Image);
            IComida baguette = _plato.PrepararPlato();

            _comida.Add(baguette);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += baguette.Costo;
            UpdateTotal();
        }

        private void vegetarianoB_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new VegetarianoBBuilder(CarneEnum.Nada, PanEnum.Integral, vegetarianoB.Image);
            IComida baguette = _plato.PrepararPlato();

            _comida.Add(baguette);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += baguette.Costo;
            UpdateTotal();
        }

        private void atunS_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new AtunSBuilder(CarneEnum.Pescado, PanEnum.Blando, atunS.Image);
            IComida sandwich = _plato.PrepararPlato();

            _comida.Add(sandwich);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += sandwich.Costo;
            UpdateTotal();
        }

        private void jamonS_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new JamonSBuilder(CarneEnum.Nada, PanEnum.Blando, jamonS.Image);
            IComida sandwich = _plato.PrepararPlato();

            _comida.Add(sandwich);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += sandwich.Costo;
            UpdateTotal();
        }

        private void milanesaS_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new MilanesaSBuilder(CarneEnum.PolloEmpanizado, PanEnum.Cristal, milanesaS.Image);
            IComida sandwich = _plato.PrepararPlato();

            _comida.Add(sandwich);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += sandwich.Costo;
            UpdateTotal();
        }

        private void quesoS_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new QuesoSBuilder(CarneEnum.Nada, PanEnum.Blando, quesoS.Image);
            IComida sandwich = _plato.PrepararPlato();

            _comida.Add(sandwich);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += sandwich.Costo;
            UpdateTotal();
        }

        private void salchichaS_Click(object sender, EventArgs e)
        {
            if (!_comida.Any())
            {
                eliminar.Enabled = true;
                pagar.Enabled = true;
            }

            _plato = new SalchichaSBuilder(CarneEnum.Nada, PanEnum.Integral, salchichaS.Image);
            IComida sandwich = _plato.PrepararPlato();

            _comida.Add(sandwich);
            dataGridView1.DataSource = new BindingSource { DataSource = _comida };
            _total += sandwich.Costo;
            UpdateTotal();
        }
    }
}
