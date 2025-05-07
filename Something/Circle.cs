using System;

namespace Something;

public class Circle
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Area => Math.PI * _radius * _radius;
}
