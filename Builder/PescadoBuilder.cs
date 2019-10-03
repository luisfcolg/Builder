using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    class PescadoBuilder : HamburguesaBuilder
    {
        public PescadoBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Nombre = "Pescado",
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
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Cebolla morada");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Mayonesa");

            _hamburguesa.StringIngredientes = string.Join(", ", _hamburguesa.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _hamburguesa.Papas = false;
        }
    }
}
