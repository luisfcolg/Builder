using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using System.Drawing;

namespace Builder.Builder
{
    class VegetarianoBBuilder : BaguetteBuilder
    {
        public VegetarianoBBuilder(CarneEnum carne, PanEnum pan, Image imagen)
        {
            _baguette = new Baguette
            {
                Pan = pan,
                Nombre = "Vegetariano",
                Foto = imagen,
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _baguette.Costo = 30.00;
        }

        public override void AgregarIngredientes()
        {
            _baguette.Ingredientes.Add("Queso");
            _baguette.Ingredientes.Add("Lechuga");
            _baguette.Ingredientes.Add("Jitomate");
            _baguette.Ingredientes.Add("Queso amarillo");
            _baguette.Ingredientes.Add("Cebolla morada");

            _baguette.StringIngredientes = string.Join(", ", _baguette.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _baguette.Papas = false;
        }
    }
}
