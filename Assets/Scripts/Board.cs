using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private FigurePositions _figurePos;

    private Cell[,] _cells;
    void Start()
    {
        _cells = _figurePos.GetPositions();
        foreach (var f in _cells)
        {
            if (f.Figure != null)
                Instantiate(f.Figure, f.Pos, Quaternion.identity);
        }
    }
    
    void Update()
    {
        
    }
}
