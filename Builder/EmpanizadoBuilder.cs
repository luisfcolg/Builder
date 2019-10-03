using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    class EmpanizadoBuilder : HamburguesaBuilder
    {
        public EmpanizadoBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Nombre = "Empanizado",
                // Foto = foto
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
            _hamburguesa.Ingredientes.Add("Mayonesa");

            _hamburguesa.StringIngredientes = string.Join(", ", _hamburguesa.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _hamburguesa.Papas = false;
        }
    }
}
