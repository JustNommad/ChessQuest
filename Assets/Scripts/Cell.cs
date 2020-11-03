using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    private Vector2 _pos;
    public FigureInfo Figure { get; set; }

    public Vector3 Pos
    {
        get => new Vector3(_pos.x, _pos.y, 1f);
    }

    public Cell(Vector2 position)
    {
        _pos = position;
    }
}
