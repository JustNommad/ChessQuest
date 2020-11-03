using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Board Config", menuName = "Chess/Board/Config", order = 0)]
public class BoardConfig : ScriptableObject
{
    [SerializeField] private int _x = 8;
    [SerializeField] private int _y = 8;

    public int X => _x;
    public int Y => _y;
    public Cell[,] Cells()
    {
        var cells = new Cell[_x, _y];
        
        for (int i = 0; i < _y; i++)
            for (int j = _x - 1; j >= 0; j--)
                cells[i,j] = new Cell(new Vector2(i, j));
        
        return cells;
    }
}
