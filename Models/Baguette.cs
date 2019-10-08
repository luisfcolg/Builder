using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Builder.Models
{
    public class Baguette : IComida
    {
        public PanEnum Pan { get; set; }
        public double Costo { get; set; }
        public string Nombre { get; set; }
        public Image Foto { get; set; }
        public CarneEnum Carne { get; set; }
        public List<string> Ingredientes { get; set; }
        public string StringIngredientes { get; set; }
        public bool Papas { get; set; }

        public Baguette()
        {

        }

        public Baguette(PanEnum pan, double costo, string nombre, CarneEnum carne, List<string> ingredientes, bool papas)
        {
            Pan = pan;
            Costo = costo;
            Nombre = nombre;
            Carne = carne;
            Ingredientes = ingredientes;
            Papas = papas;
        }
    }
}
