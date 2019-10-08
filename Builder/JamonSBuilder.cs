using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using System.Drawing;

namespace Builder.Builder
{
    class JamonSBuilder : SandwichBuilder
    {
        public JamonSBuilder(CarneEnum carne, PanEnum pan, Image imagen)
        {
            _sandwich = new Sandwich
            {
                Pan = pan,
                Nombre = "Jamon",
                Foto = imagen,
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _sandwich.Costo = 25.00;
        }

        public override void AgregarIngredientes()
        {
            _sandwich.Ingredientes.Add("Lechuga");
            _sandwich.Ingredientes.Add("Jamon");
            _sandwich.Ingredientes.Add("Queso");
            _sandwich.Ingredientes.Add("Jitomate");
            _sandwich.Ingredientes.Add("Mayonesa");
            _sandwich.Ingredientes.Add("Mostaza");

            _sandwich.StringIngredientes = string.Join(", ", _sandwich.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _sandwich.Papas = false;
        }
    }
}
