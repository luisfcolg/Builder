using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;
using Builder.Models;

namespace Builder.Director
{
    public class Cocina
    {
        private HamburguesaBuilder _hamburguesaBuilder;

        public void RecepcionarHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            _hamburguesaBuilder = hamburguesaBuilder;
        }

        public void CocinarHamburguesaPasoAPaso()
        {
            _hamburguesaBuilder.EstablecerCosto();
            _hamburguesaBuilder.AgregarIngredientes();
            _hamburguesaBuilder.AgregarPapas();
        }

        public Hamburguesa HamburguesaPreparada => _hamburguesaBuilder.ObtenerHamburguesa();

        public Hamburguesa CocinarHamburguesa(HamburguesaBuilder hamburguesaBuilder)
        {
            hamburguesaBuilder.EstablecerCosto();
            hamburguesaBuilder.AgregarIngredientes();
            hamburguesaBuilder.AgregarPapas();
            return hamburguesaBuilder.ObtenerHamburguesa();
        }
    }
}
