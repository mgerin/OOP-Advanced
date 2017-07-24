using System;

public class Circle : IDrawable
{
    private int radius;

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public int Radius
    {
        get { return this.radius; }
        private set { this.radius = value; }
    }

    public void Draw()
    {
        var radiusIn = this.Radius - 0.4;
        var radiusOut = this.Radius + 0.4;
        for (double y = this.Radius; y >= -this.Radius; y--)
        {
            for (double x = -this.Radius; x < radiusOut; x += 0.5)
            {
                var value = (x * x) + (y * y);
                if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
