using System;
using Cysharp.Threading.Tasks;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;

namespace Behaviours
{
    [Serializable]
    public class ColorBehaviour : IBehaviour
    {
        public UniTask Play(GameObject obj, BehaviourParameters parameters)
        {
            var renderer = obj.GetComponent<Renderer>();

            return renderer.material.DOColor(parameters.Color, parameters.Time).ToUniTask();
        }
    }
}