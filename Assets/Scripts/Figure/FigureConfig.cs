using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Figure Config", menuName = "Chess/Figure/Config", order = 1)]
public class FigureConfig : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private FigureInfo[] _eightFigures;
    [SerializeField] private FigureInfo[] _twoFigures;
    [SerializeField] private FigureInfo[] _oneFigures;

    public string ID => _id;

    public string[] GetIDs()
    {
        return UniteGroup().Select(figure => figure.ID).ToArray();
    }
    public FigureInfo GetFigureInfo(string id)
    {
        return UniteGroup().FirstOrDefault(figure => figure.ID == id);
    }

    public Dictionary<int, FigureInfo[]> GetNumberOfTypes()
    {
        var group = new Dictionary<int, FigureInfo[]>();
        group.Add(8, _eightFigures);
        group.Add(2, _twoFigures);
        group.Add(1, _oneFigures);

        return group;
    }
    private FigureInfo[] UniteGroup()
    {
        var group = new FigureInfo[6];
        int count = 0;
        foreach (var f in _twoFigures)
        {
            group[count++] = f;
        }

        foreach (var f in _oneFigures)
        {
            group[count++] = f;
        }

        group[count] = _eightFigures[0];
        return group;
    }
}
