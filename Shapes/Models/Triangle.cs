namespace Shapes.Models;

/// <summary>
/// Represents triangle
/// </summary>
public class Triangle : IArea
{
    private double _a;
    private double _b;
    private double _c;

    /// <summary>
    /// Initializes new Triangle instance with all edges equal zero
    /// </summary>
    public Triangle()
    {
        _a = 0;
        _b = 0;
        _c = 0;
    }

    /// <summary>
    /// Initializes new Triangle instance with edges
    /// </summary>
    /// <param name="a"> Triangle's edge </param>
    /// <param name="b"> Triangle's edge </param>
    /// <param name="c"> Triangle's edge </param>
    /// <exception cref="ArgumentOutOfRangeException"> Triangle with such parameters doesn't exists </exception>
    public Triangle(double a, double b, double c)
    {
        if (!IsTriangleExists(a, b, c))
        {
            throw new ArgumentOutOfRangeException("Triangle isn't exist");
        }
        _a = a;
        _b = b;
        _c = c;
    }

    /// <summary>
    /// Represents one of the rectangle's edge
    /// </summary>
    public double a
    {
        get => _a;
        set
        {
            if (!IsTriangleExists(value, _b, _c))
            {
                throw new ArgumentOutOfRangeException("Triangle isn't exist");
            }

            _a = value;
        }
    }

    /// <summary>
    /// Represents one of the rectangle's edge
    /// </summary>
    public double b
    {
        get => _b;
        set
        {
            if (!IsTriangleExists(_a, value, _c))
            {
                throw new ArgumentOutOfRangeException("Triangle isn't exist");
            }

            _b = value;
        }
    }

    /// <summary>
    /// Represents one of the rectangle's edge
    /// </summary>
    public double c
    {
        get => _c;
        set
        {
            if (!IsTriangleExists(_a, _b, value))
            {
                throw new ArgumentOutOfRangeException("Triangle isn't exist");
            }

            _c = value;
        }
    }

    /// <summary>
    /// Sets new edges for triangle
    /// </summary>
    /// <param name="a"> New edge </param>
    /// <param name="b"> New edge </param>
    /// <param name="c"> New edge </param>
    /// <exception cref="ArgumentOutOfRangeException"> Triangle with new parameters doesn't exist </exception>
    public void SetNewEdges(double a, double b, double c)
    {
        if (!IsTriangleExists(a, b, c))
        {
            throw new ArgumentOutOfRangeException("Triangle isn't exist");
        }

        _a = a;
        _b = b;
        _c = c;
    }

    /// <summary>
    /// Get Triangle's area
    /// </summary>
    /// <returns> Are of Triangle </returns>
    public double GetArea()
    {
        var p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    private bool IsTriangleExists(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            return false;
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            return false;
        }
        return true;
    }
}