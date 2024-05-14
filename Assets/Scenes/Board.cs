using System.Collections;
using System.Collections.Generic;

public class Board
{
    private static Board _instance;
    public static Board Instance { get { return _instance ??= new Board(); } }
    static void Main()
    {
        List<(int,int)> _grids = new List<(int, int)>(81);
    }
}