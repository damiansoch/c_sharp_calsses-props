using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace props
{
    internal class Box
    {
        //constructor
        public Box(int length,int heigth,int width)
        {
            this.length = length;   
            this.heigth = heigth;
            this.Width=width;
        }


        //member variables
        private int length =3;
        private int heigth;
        //public int width; you dont have to have member property, you van just use the props -3-
        private int volume;
        

        public void DisplayInfo()
        {
            Console.WriteLine("Length = {0}, heigth = {1}, width = {2}, volume = {3}",length,heigth,Width,GetVolume()); //Width, because is not setup thru member variables
        }

        //setting thruought method -1-
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetVolume()
        {
            return length * Width * heigth;
        }

        //setting thruought props -2-
       public int Height
        {
            get { return heigth; }
            set { heigth = value; }
        }
        //-3-
        public int Width { get; set; }//default getter, setter

        public int Volume
        {
            get { return this.length*this.heigth*this.Width;  }
            
        }

        public int FrontSurface
        {
            get { return this.heigth * this.length; }
        } 
    }
}
