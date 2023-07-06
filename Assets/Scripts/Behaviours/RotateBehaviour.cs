using System;
using Cysharp.Threading.Tasks;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;

namespace Behaviours
{
    [Serializable]
    public class RotateBehaviour : IBehaviour
    {
        public UniTask Play(GameObject obj, BehaviourParameters parameters)
        {
            return obj.transform.DORotate(parameters.Coord, parameters.Time).ToUniTask();
        }
    }
}