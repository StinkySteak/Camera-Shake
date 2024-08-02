using UnityEngine;

// Don't forget to add this.
using CameraShake;

public class ShakeTrigger : MonoBehaviour
{
    // Parameters of the shake to tweak in the inspector.
    public BounceShake.Params shakeParams;

    private BounceShakePool _pool;

    private void Start()
    {
        _pool = new();
        _pool.InitPool();
    }

    // This is called by animator.
    public void Stomp()
    {
        Vector3 sourcePosition = transform.position;
        BounceShake shake = _pool.GetShake();
        shake.Initialize(shakeParams, sourcePosition);

        // Creating new instance of a shake and registering it in the system.
        CameraShaker.Shake(shake);
    }
}
