using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public abstract class BaguetteBuilder : Plato
    {
        protected Baguette _baguette;

        public string Carne { get; set; }
        public string Pan { get; set; }

        public Baguette ObtenerBaguette() { return _baguette; }

        public virtual void EstablecerCosto()
        {

        }

        public virtual void AgregarIngredientes()
        {

        }

        public virtual void AgregarPapas()
        {

        }

        public override IComida PrepararPlato()
        {
            EstablecerCosto();
            AgregarIngredientes();
            AgregarPapas();

            return _baguette;
        }
    }
}
