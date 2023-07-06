using System;
using Cysharp.Threading.Tasks;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;

namespace Behaviours
{
    [Serializable]
    public class MoveBehaviour : IBehaviour
    {
        public UniTask Play(GameObject obj, BehaviourParameters parameters)
        {
            return obj.transform.DOMove(parameters.Transform.position, parameters.Time).ToUniTask();
        }
    }
}