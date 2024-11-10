namespace GraphicEditor
{
    class Program
    {
        static void Main()
        {
            GraphicEditor editor = new GraphicEditor();

            Circle circle = new Circle();
            editor.DrawShape(circle);

            IShape shape = new Rectangle();
            editor.DrawShape(shape);

            shape = new Square();
            editor.DrawShape(shape);
        }
    }
}
