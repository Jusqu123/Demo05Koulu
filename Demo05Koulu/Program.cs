using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Koulu
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstractissa luokassa ei voi tehdä oliota! DrawingObject do = new DrawingObject();


            Circle circle = new Circle();
            circle.Name = "My cicle";
            circle.Draw();
            

            Square square = new Square();
            square.Name = "test square";
            square.Draw();

            // Create a list collection for drawing objects
            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            // add few objects to collection
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());



            // loop collection and draw objects
            Console.WriteLine("Drawing objects in a List");
            foreach (DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw();
            }

        }
    }
}
