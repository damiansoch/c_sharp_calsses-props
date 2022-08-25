using System;

namespace props
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Box box = new(10,10,30);

            ////using prop -2-
            //box.Height = 4;
            //box.Width = 5; 
            //commented out because of use of the constuctor


            //using function -1-
            box.SetLength(4);
            //box.lenght - no access because is private, we need to setup the get in the class to nbe able to access this
            int length = box.GetLength();
            Console.WriteLine(length);


            box.DisplayInfo();

            //returning Volume from prop
            Console.WriteLine("Volume = {0}", box.Volume);
            Console.WriteLine("The front surface of the Box is: {0}",box.FrontSurface);

            Console.ReadLine();

        }
    }
}
