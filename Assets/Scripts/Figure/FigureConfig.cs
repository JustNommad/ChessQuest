using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Figure Config", menuName = "Chess/Figure/Config", order = 1)]
public class FigureConfig : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private FigureInfo[] _group;

    public string ID => _id;
    public FigureInfo[] Group => _group;
}
