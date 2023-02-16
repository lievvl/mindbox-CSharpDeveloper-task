using NUnit.Framework;
using Shapes.Models;

namespace Shapes.Test;

public class Tests
{
    private const double error = 1e-9;

    [Test]
    public void TryToCreateNonExistingFigures_CatchException()
    {
        Assert.Catch(() =>
        {
            IArea circle = new Circle(-20);
        });

        Assert.Catch(() =>
        {
            IArea triangle = new Triangle(-20, 1, 1);
        });

        Assert.Catch(() =>
        {
            IArea triangle = new Triangle(1, -20, 1);
        });

        Assert.Catch(() =>
        {
            IArea triangle = new Triangle(1, 1, -20);
        });

        Assert.Catch(() =>
        {
            IArea triangle = new Triangle(100, 1, 1);
        });
    }

    [Test]
    public void CreateGoodTriangle_SetBadEdges_CatchException()
    {
        Triangle triangle = new Triangle(1, 1, 1);
        Assert.Catch(() =>
        {
            triangle.a = -1;
        });

        Assert.Catch(() =>
        {
            triangle.b = 100;
        });

        Assert.Catch(() =>
        {
            triangle.c = 4;
        });

        Assert.Catch(() =>
        {
            triangle.SetNewEdges(20, 1, 1);
        });
    }

    [Test]
    public void CalculateAreas()
    {
        IArea circle = new Circle(1);
        IArea triangle = new Triangle(5, 4, 3);
        Assert.AreEqual(Math.PI, circle.GetArea(), error);
        Assert.AreEqual(6.0, triangle.GetArea(), error);
    }
}