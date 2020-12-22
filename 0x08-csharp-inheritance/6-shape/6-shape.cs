﻿using System;

/// <summary> Represents a class Shape</summary>
class Shape
{
/// <summary> Not implemented method Area()</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary> Represents a class Rectangle that inherits from class Shape</summary>
class Rectangle : Shape 
{
    private int width;
    private int height;
    
    /// <summary> Gets ans sets width of Rectangle</summary>
    public int Width {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary> Gets ans sets height of Rectangle</summary>
    public int Height {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

}