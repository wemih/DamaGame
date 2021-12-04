using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamaGame
{
    class Player
    {
        readonly private bool isDebugMode;
        private string name;
        private string color;

        public Player(bool isDebugMode, string name)
        {
            this.isDebugMode = isDebugMode;
            this.name = name;
            if (this.isDebugMode) Console.WriteLine($"Player generatred: {this.name}");
        }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
    }
}
