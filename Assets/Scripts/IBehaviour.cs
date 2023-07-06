using System;
using Cysharp.Threading.Tasks;
using DefaultNamespace;
using UnityEngine;

public interface IBehaviour
{
    public UniTask Play(GameObject obj, BehaviourParameters parameters);
}