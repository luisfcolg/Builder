using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Builder.Models
{
    public interface IComida
    {
        PanEnum Pan { get; set; }
        double Costo { get; set; }
        string Nombre { get; set; }
        Image Foto { get; set; }
        CarneEnum Carne { get; set; }
        List<string> Ingredientes { get; set; }
        string StringIngredientes { get; set; }
        bool Papas { get; set; }
    }
}
