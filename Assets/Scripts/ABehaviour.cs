using System;
using DefaultNamespace;
using UnityEngine;

[Serializable]
public class ABehaviour
{
    [SerializeField] private float _time;
    [SerializeField] private BehaviourType _behaviourType;
    [SerializeField] private Transform _transformTarget;
    [SerializeField] private Vector3 _vector3Target;
    [SerializeField] private Color _colorTarget;

    public BehaviourType Type => _behaviourType;

    public BehaviourParameters Parameters => new()
    {
        Time = _time,

        Transform = _transformTarget,
        Coord = _vector3Target,
        Color = _colorTarget,
    };
}