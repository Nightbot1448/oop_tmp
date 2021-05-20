namespace Shapes
{
    public abstract class Shape
    {
        protected Location _location;  // поле доступное в классе наследнике
        public Shape(int x, int y)
        {
            _location = new Location { X = x, Y = y }; // специальный синтаксис инициализации свойств объекта
        }

        public abstract void Show();
    }
}
