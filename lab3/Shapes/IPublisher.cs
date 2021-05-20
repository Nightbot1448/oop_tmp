using System;

namespace Shapes
{
    public interface IPublisher
    {
        event EventHandler<Location> LocationChanged;
    }
}
