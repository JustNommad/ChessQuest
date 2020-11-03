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
        var group = _figureConfig.GetNumberOfTypes();
        var _boardCells = _boardConfig.Cells();

        for (int i = 0; i < _boardConfig.X; i++)
        {
            foreach (var f in group[8])
            {
                _boardCells[i, 1].Figure = f;
                _boardCells[i, _boardConfig.Y - 2].Figure = f;
            }
        }
        
        for (int i = 0; i < (_boardConfig.X / 2) - 1; i++)
        {
            foreach (var f in group[8])
            {
                _boardCells[i, 0].Figure = _boardCells[i, _boardConfig.Y - 1].Figure = f;
                _boardCells[_boardConfig.X - i, 0].Figure = 
                    _boardCells[_boardConfig.X - i, _boardConfig.Y - 1].Figure = f;
            }
        }

        for (int i = _boardConfig.X / 2; i < _boardConfig.X / 2 + 1; i++)
        {
            foreach (var f in group[1])
            {
                _boardCells[i, 0].Figure = f;
                _boardCells[i, _boardConfig.Y - 1].Figure = f;
            }
        }

        return _boardCells;
    }
}
