namespace Shapes.Models;

/// <summary>
/// Interface representing shapes with countable area
/// </summary>
public interface IArea
{
    /// <summary>
    /// Get shape's area
    /// </summary>
    /// <returns> Area of shape </returns>
    public double GetArea();
}