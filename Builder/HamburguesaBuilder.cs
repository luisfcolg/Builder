using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public abstract class HamburguesaBuilder
    {
        protected Hamburguesa _hamburguesa;

        public string Carne { get; set; }
        public string Pan { get; set; }

        public Hamburguesa ObtenerHamburguesa() { return _hamburguesa; }

        public virtual void EstablecerCosto()
        {

        }

        public virtual void AgregarIngredientes()
        {

        }

        public virtual void AgregarPapas()
        {

        }
    }
}
