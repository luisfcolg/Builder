using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.Builder
{
    public abstract class SandwichBuilder : Plato
    {
        protected Sandwich _sandwich;

        public string Carne { get; set; }
        public string Pan { get; set; }

        public Sandwich ObtenerSandwich() { return _sandwich; }

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

            return _sandwich;
        }
    }
}
