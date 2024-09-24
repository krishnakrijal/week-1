// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

var square = new Square(10);

try
{


    square.SetArea(2);


    Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




var circle = new Circle(4);

ShapeColourHelper.GetRandomColor(circle);

Console.WriteLine("Random color of circle "+ ShapeColourHelper.GetRandomColor(circle));


// Generate an array of shapes
IShape[] shapes = new IShape[]
{
            new Circle(5),
            new Triangle(4, 3),
            new Circle(2),
};

// Print area and color of each shape
foreach (IShape shape in shapes)
{
    Console.WriteLine($"{shape.GetType().Name} - Area: {shape.GetArea()}, Color: {shape.Color.Name}");
}


ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);


Console.ReadLine();




