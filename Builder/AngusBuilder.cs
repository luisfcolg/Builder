using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using System.Drawing;

namespace Builder.Builder
{
    class AngusBuilder : HamburguesaBuilder
    {
        public AngusBuilder(CarneEnum carne, PanEnum pan, Image imagen)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,  
                Nombre = "Angus",
                Foto = imagen,
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _hamburguesa.Costo = 60.00;
        }

        public override void AgregarIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Cebolla morada");
            _hamburguesa.Ingredientes.Add("Aguacate");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Queso");

            _hamburguesa.StringIngredientes = string.Join(", ", _hamburguesa.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _hamburguesa.Papas = true;
        }
    }
}
