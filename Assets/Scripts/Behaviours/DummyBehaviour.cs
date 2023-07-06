using System;
using Cysharp.Threading.Tasks;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;

namespace Behaviours
{
    [Serializable]
    public class DummyBehaviour : IBehaviour
    {
        public UniTask Play(GameObject obj, BehaviourParameters parameters)
        {
            return UniTask.CompletedTask;
        }
    }
}