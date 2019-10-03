using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    class PolloBuilder : HamburguesaBuilder
    {
        public PolloBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Nombre = "Pollo",
                // Foto = foto
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
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Queso");
            _hamburguesa.Ingredientes.Add("Queso amarillo");

            _hamburguesa.StringIngredientes = string.Join(", ", _hamburguesa.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _hamburguesa.Papas = false;
        }
    }
}
