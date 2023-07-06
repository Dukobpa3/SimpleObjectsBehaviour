using System.Collections.Generic;
using Behaviours;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BehaviourProcessor : MonoBehaviour
{
    [SerializeField] private bool _playLoop;
    [SerializeField] private List<ABehaviour> _behaviours;

    private readonly Dictionary<BehaviourType, IBehaviour> _strategies = new Dictionary<BehaviourType, IBehaviour>()
    {
        { BehaviourType.None, new DummyBehaviour() },
        { BehaviourType.Move, new MoveBehaviour() },
        { BehaviourType.Color, new ColorBehaviour() },
        { BehaviourType.Rotate, new RotateBehaviour() },
        { BehaviourType.LookAt, new LookAtBehaviour() },
    };

    private void Start()
    {
        PlaySequence()
           .AttachExternalCancellation(this.GetCancellationTokenOnDestroy())
           .Forget();
    }

    private async UniTask PlaySequence()
    {
        foreach (var behaviour in _behaviours)
        {
            await _strategies[behaviour.Type].Play(gameObject, behaviour.Parameters)
                                             .AttachExternalCancellation(this.GetCancellationTokenOnDestroy());
        }

        if (_playLoop)
        {
            await PlaySequence()
               .AttachExternalCancellation(this.GetCancellationTokenOnDestroy());
        }
    }
}