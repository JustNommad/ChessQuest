using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Figure Info", menuName = "Chess/Figure/Info", order = 0)]
public class FigureInfo : ScriptableObject
{
    [SerializeField] private string _id;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private string _type;
    [SerializeField] private Vector2 _movementType;

    public string ID => _id;
    public GameObject Prefab => _prefab;
    public string Type => _type;
    public Vector2 MovementType => _movementType;
}
