using Task3;

IGraphic vector = new Vector();
IGraphic bitmap = new Bitmap();

Shape square = new Square(vector);
Shape triangle = new Triangle(bitmap);
Shape circle = new Circle(vector);

square.Draw();
triangle.Draw();
circle.Draw();