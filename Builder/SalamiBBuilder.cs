﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;
using System.Drawing;

namespace Builder.Builder
{
    class SalamiBBuilder : BaguetteBuilder
    {
        public SalamiBBuilder(CarneEnum carne, PanEnum pan, Image imagen)
        {
            _baguette = new Baguette
            {
                Pan = pan,
                Nombre = "Salami",
                Foto = imagen,
                Carne = carne,
                Ingredientes = new List<string>()
            };
        }

        public override void EstablecerCosto()
        {
            _baguette.Costo = 35.00;
        }

        public override void AgregarIngredientes()
        {
            _baguette.Ingredientes.Add("Salami");
            _baguette.Ingredientes.Add("Queso");
            _baguette.Ingredientes.Add("Aceitunas");
            _baguette.Ingredientes.Add("Adereso");

            _baguette.StringIngredientes = string.Join(", ", _baguette.Ingredientes.ToArray());
        }

        public override void AgregarPapas()
        {
            _baguette.Papas = false;
        }
    }
}