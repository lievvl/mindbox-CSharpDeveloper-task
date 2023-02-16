namespace Shapes.Models;

/// <summary>
/// Represents Circle
/// </summary>
public class Circle : IArea
{
    private double _r;

    /// <summary>
    /// Initializes new Circle instance with radius equal zero
    /// </summary>
    public Circle()
    {
        _r = 0;
    }

    /// <summary>
    /// Initializes new Circle instance
    /// </summary>
    /// <param name="r"> Circle's radius </param>
    /// <exception cref="ArgumentOutOfRangeException"> radius is less than zero </exception>
    public Circle(double r)
    {
        if (r < 0)
        {
            throw new ArgumentOutOfRangeException("Radius cannot be negative");
        }
        _r = r;
    }

    /// <summary>
    /// Circle's radius
    /// </summary>
    public double R
    {
        get => _r;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Radius cannot be negative");
            }

            _r = value;
        }
    }

    /// <summary>
    /// Get Circle's area
    /// </summary>
    /// <returns> Area of circle </returns>
    public double GetArea()
    {
        return Math.PI * _r * _r;
    }
}