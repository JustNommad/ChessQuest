using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using UnityEngine;

[CreateAssetMenu(fileName = "Figure Group", menuName = "Chess/Figure/Group", order = 1)]
public class FigureGroup : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private FigureInfo[] _figureGroup;
    
    public string ID => _id;

    public string[] GetIDs()
    {
        return _figureGroup.Select(figure => figure.ID).ToArray();
    }
    public FigureInfo GetFigureInfo(string id)
    {
        return _figureGroup.FirstOrDefault(figure => figure.ID == id);
    }
}
