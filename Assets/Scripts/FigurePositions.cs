using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Figure Positions", menuName = "Chess/Figure/Positions", order = 3)]
public class FigurePositions : ScriptableObject
{
    [SerializeField] private FigureConfig _figureConfig;
    [SerializeField] private BoardConfig _boardConfig;

    public Cell[,] GetPositions()
    {
        var group = _figureConfig.Group;
        var _boardCells = _boardConfig.Cells();

        foreach (var f in group)
        {
            var posX = (int)f.StartingPosition.x;
            var posY = (int)f.StartingPosition.y;
            _boardCells[posX, posY].Figure = f;
        }

        _boardCells[_boardConfig.X/2, _boardConfig.Y - 1].Figure 
            = _boardCells[_boardConfig.X/2 - 1, 0].Figure;
        _boardCells[_boardConfig.X/2 - 1, _boardConfig.Y - 1].Figure 
            = _boardCells[_boardConfig.X/2, 0].Figure;
        
        for (int i = 0; i < _boardConfig.X; i++)
        {
            _boardCells[i, 1].Figure 
                = _boardCells[i, _boardConfig.Y - 2].Figure 
                = _boardCells[0, 1].Figure;
        }
        for (int i = 0; i < (_boardConfig.X / 2) - 1; i++)
        {
            _boardCells[i, _boardConfig.Y - 1].Figure 
                = _boardCells[i, 0].Figure
                = _boardCells[_boardConfig.X - 1 - i, 0].Figure 
                = _boardCells[_boardConfig.X - 1 - i, _boardConfig.Y - 1].Figure
                = _boardCells[i, 0].Figure;
        }

        return _boardCells;
    }
}
