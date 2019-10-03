using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    class ArracheraBuilder : HamburguesaBuilder
    {
        public ArracheraBuilder(CarneEnum carne, PanEnum pan)
        {
            _hamburguesa = new Hamburguesa
            {
                Pan = pan,
                Nombre = "Arrachera",
                // Foto = foto
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _hamburguesa.Costo = 70.00;
        }

        public override void AgregarIngredientes()
        {
            _hamburguesa.Ingredientes.Add("Lechuga");
            _hamburguesa.Ingredientes.Add("Cebolla morada");
            _hamburguesa.Ingredientes.Add("Aguacate");
            _hamburguesa.Ingredientes.Add("Jitomate");
            _hamburguesa.Ingredientes.Add("Tocino");
            _hamburguesa.Ingredientes.Add("Ranch");

            _hamburguesa.StringIngredientes = string.Join(", ", _hamburguesa.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {   
            _hamburguesa.Papas = true;
        }
    }
}
