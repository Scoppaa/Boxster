using System;

namespace Class_Practice
{
    class Box
    {
        //Variables for length, width, and height
        private double length;
        private double width;
        private double height;

        //Method that changes the length of the box
        public void SetLength(double len)
        {
            length = len;
        }

        //Method that changes the width of the box
        public void setWidth(double wid)
        {
            width = wid;
        }

        //Method that changes the height of the box
        public void setHeight(double hei)
        {
            height = hei;
        }

        //Method that will return the length of the box
        public double getLength()
        {
            return length;
        }

        //Method that will return the width of the box
        public double getWidth()
        {
            return width;
        }

        //Method that will return the height of the box
        public double getHeight()
        {
            return height;
        }

        //Method that will return the volume of the box
        public double getVolume()
        {
            return length * width * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create 2 box instances
            Box box1 = new Box();
            Box box2 = new Box();

            //Setters for box1
            box1.setLength(6.0);
            box1.setWidth(7.0);
            box1.setHeight(8.0);

            //Setters for box2
            box2.setLength(5.0);
            box2.setWidth(9.0);
            box2.setHeight(2.0);

            //Assigns volume1 the volume of box 1
            double volumeBox1 = box1.getVolume();
            double volumeBox2 = box2.getVolume();

            //Output of box 1's length, width, height, and volume
            Console.WriteLine("The length of box 1 is: " + box1.getLength());
            Console.WriteLine("The width of box 1 is: " + box1.getWidth());
            Console.WriteLine("The height of box 1 is: " + box1.getHeight());
            Console.WriteLine("The volume of box 1 is: " + volumeBox1);

            Console.WriteLine();

            //Output of box 2's length, width, height, and volume
            Console.WriteLine("The length of box 2 is: " + box2.getLength());
            Console.WriteLine("The width of box 2 is: " + box2.getWidth());
            Console.WriteLine("The height of box 2 is: " + box2.getHeight());
            Console.WriteLine("The volume of box 2 is: " + volumeBox2);
        }
    }
}
