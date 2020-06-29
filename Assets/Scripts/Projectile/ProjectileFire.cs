using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    public Transform playerTrail;
    public Transform player;
    public PlayerInput input;

    public GameObject projectilePrefab;

    [SerializeField]
    private float fireCooldown = .2f;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (input.Fire && timer > fireCooldown && playerTrail.childCount > 0)
        {
            // Destroy trail
            var blob = playerTrail.GetChild(0).gameObject;
            Transform firePoint = blob.transform;
            Destroy(blob);

            // Spawn projectile
            var projectile = Instantiate(projectilePrefab);
            projectile.transform.position = firePoint.position;

            // Launch projectile

            Vector3 direction = player.position - projectile.transform.position;
            direction = direction.sqrMagnitude > 0 ? direction.normalized : input.Movement.normalized;
            projectile.GetComponent<ProjectileMovement>().Launch(direction);

            // Reset timer
            timer = 0;
        }
    }

}
