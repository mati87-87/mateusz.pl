using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Point
{
    private int xpos;
    private int ypos;

    public Point()
    {
        xpos = 0;
        ypos = 0;
    }
    public int GetX()
    {
        return xpos;
    }
    public int GetY()
    {
        return ypos;
    }
}