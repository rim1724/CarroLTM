using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroApp
{
  public  class Player
    {
        private String name;
        public string Name { get => name; set => name = value; }
        private Image image;
        public Image Image { get => image; set => image = value; }
        public Player(String name,Image image)
        {
            this.name = name;
            this.image = image;
        }
       
    }
}
