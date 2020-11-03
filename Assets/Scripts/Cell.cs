using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell
{
    private Vector2 _pos;
    public FigureInfo Figure { get; set; }

    public Vector3 Pos
    {
        get => new Vector3(_pos.x, 0.0f, _pos.y);
    }

    public Cell(Vector2 position)
    {
        _pos = position;
    }
}
