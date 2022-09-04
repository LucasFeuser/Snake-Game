using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaCobrona
{
    internal class Comida
    {
        //Property modify x and y
        public Point Location { get; private set; } //Private apenas para acessar o valor

        //Method create food
        public void CreateFood()
        {
            Random rnd = new Random(); //Class random to spawn random itens;
            Location = new Point(rnd.Next(0,27), rnd.Next(0,27)); //Pass value x and y to random;
        }
    }
}
