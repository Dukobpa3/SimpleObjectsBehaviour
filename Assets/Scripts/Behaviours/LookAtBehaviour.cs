using Cysharp.Threading.Tasks;
using DefaultNamespace;
using DG.Tweening;
using UnityEngine;

namespace Behaviours
{
    public class LookAtBehaviour : IBehaviour
    {
        public UniTask Play(GameObject obj, BehaviourParameters parameters)
        {
            return obj.transform.DOLookAt(parameters.Transform.position, parameters.Time).ToUniTask();
        }
    }
}