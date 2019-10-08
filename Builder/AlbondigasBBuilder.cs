using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using System.Drawing;

namespace Builder.Builder
{
    class AlbondigasBBuilder : BaguetteBuilder
    {
        public AlbondigasBBuilder(CarneEnum carne, PanEnum pan, Image imagen)
        {
            _baguette = new Baguette
            {
                Pan = pan,
                Nombre = "Albondigas",
                Foto = imagen,
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _baguette.Costo = 50.00;
        }

        public override void AgregarIngredientes()
        {
            _baguette.Ingredientes.Add("Albondigas");
            _baguette.Ingredientes.Add("Salsa");
            _baguette.Ingredientes.Add("Especias");
            _baguette.Ingredientes.Add("Cebolla");
            _baguette.Ingredientes.Add("Queso");

            _baguette.StringIngredientes = string.Join(", ", _baguette.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _baguette.Papas = false;
        }
    }
}
