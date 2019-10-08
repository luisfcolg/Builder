using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using System.Drawing;

namespace Builder.Builder
{
    class KobeBuilder : HamburguesaBuilder
    {
        public KobeBuilder(CarneEnum carne, PanEnum pan, Image image)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Nombre = "Kobe",
                Foto = image,
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _hamburguesa.Costo = 55.00;
        }

        public override void AgregarIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Pepinillos");
            _hamburguesa.Ingredientes.Add("Cebolla morada");
            _hamburguesa.Ingredientes.Add("Queso amarillo");
            _hamburguesa.Ingredientes.Add("Tocino");
            _hamburguesa.Ingredientes.Add("Catsup");

            _hamburguesa.StringIngredientes = string.Join(", ", _hamburguesa.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _hamburguesa.Papas = false;
        }
    }
}
