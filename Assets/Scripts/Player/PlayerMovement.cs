using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform player;
    public PlayerInput input;
    public Rigidbody2D rb;

    [SerializeField]
    private float movementSpeed = 5f;

    private void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        if (input.Movement.sqrMagnitude > 0)
        {

            rb.MovePosition(player.position + input.Movement * movementSpeed * Time.fixedDeltaTime);
        }
    }
}
