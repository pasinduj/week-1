// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;


// all Shapes in the array
 string[] Shapes = { "Square", "Circle", "Triangle" };

for (int i=0; i < Shapes.Length; i++ ) {
    if (Shapes[i] == "Square")
    {

        var square = new Square(10);

        try
        {

            square.SetArea(2);

            Console.WriteLine("The Square area is " + square.GetArea());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


       // ShapeColourHelper.AddColour(square);

       // Console.WriteLine(square.Colour);

       // ShapeColourHelper.ChangeColour(square);

       // Console.WriteLine(square.Colour);

        // Random color pick and print here
        ShapeColourHelper.RandomColour(square);

        Console.WriteLine(square.Colour);

        Console.WriteLine("========================== " );
    }

    if (Shapes[i] == "Circle")
    {

        var circle = new Circle(2);

        try
        {

            circle.SetArea(2);

            Console.WriteLine("The Circle area is " + circle.GetArea());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }




        //var circle = new Circle();

        // ShapeColourHelper.AddColour(circle);

       // ShapeColourHelper.AddColour(circle);

       // Console.WriteLine(circle.Colour);

       // ShapeColourHelper.ChangeColour(circle);

       // Console.WriteLine(circle.Colour);

        // Random color pick and print here
        ShapeColourHelper.RandomColour(circle);

        Console.WriteLine(circle.Colour);

        Console.WriteLine("========================== ");

    }

    if (Shapes[i] == "Triangle")
    {
        Console.WriteLine("Triangle");

        var triangle = new Triangle();

        ShapeColourHelper.RandomColour(triangle);

        Console.WriteLine(triangle.Colour);

        Console.WriteLine("========================== ");

    }


    }


Console.ReadLine();




