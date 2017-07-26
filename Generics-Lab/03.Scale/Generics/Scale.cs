using System;

public class Scale<T>
    where T : IComparable<T>
{
    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    private T Left { get; }

    private T Right { get; }

    public T GetHavier()
    {
        if (this.Left.CompareTo(this.Right) > 0)
        {
            return this.Left;
        }

        if (this.Right.CompareTo(this.Left) > 0)
        {
            return this.Right;
        }

        return default(T);
    }
}
