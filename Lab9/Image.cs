using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Image
    {

        public  Image(string name, int height, int width)
            {
            this.height = height;
            this.width = width;
            this.name = name;
        }
        public Image()
        {
           
        }

        public  int height { get; set; }
        public int width { get; set; }
        public string name { get; set; }

        public void SetInf(string name, int height, int width)
        {
            this.height = height;
            this.width = width;
             this.name = name;
        }

        public override string ToString()
        {
            return $"Название: {name}, Высота: {height}, Ширина: {width} ";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Image image) return (name == image.name && width == image.width && height == image.height);
            return false;
        }
    }
}
