using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteAnimation : MonoBehaviour
{
    [SerializeField]
    private PlayerInput input;

    public Transform sprite;
    public Animator animator;

    private void Start()
    {
        input = sprite.parent.GetComponent<PlayerInput>();
    }

    private void Update()
    {
        animator.SetFloat("Horizontal", input.Movement.x);
        animator.SetFloat("Vertical", input.Movement.y);
        animator.SetFloat("Speed", input.Movement.sqrMagnitude);

        int xScale = input.Movement.x < 0 ? -1 : 1;
        

        sprite.localScale = new Vector3(xScale, 1, 1);
    }
}
