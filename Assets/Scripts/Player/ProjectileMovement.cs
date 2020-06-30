using System;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public Transform projectile;
    public Rigidbody2D rb;

    [SerializeField]
    public float projectileSpeed;

    public void Launch(Vector3 direction)
    {
        // Launch towards target
        rb.AddForce(direction * projectileSpeed, ForceMode2D.Impulse);

        // Set projectile rotation
        //var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        //projectile.rotation = rotation;

    }
}
