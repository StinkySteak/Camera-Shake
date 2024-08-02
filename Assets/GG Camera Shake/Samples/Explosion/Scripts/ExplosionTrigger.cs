using UnityEngine;

// Don't forget to add this.
using CameraShake;

public class ExplosionTrigger : MonoBehaviour
{
    private Explosion explosion;

    private void Start()
    {
        explosion = FindObjectOfType<Explosion>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            explosion.Explode();

            // Shaking the camera.
            CameraShaker.Presets.ShortShake2D();
        }
    }
}
