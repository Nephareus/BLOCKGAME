using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D rb;
    public Animator anim;
    private Vector2 vel;

    private void Awake()
    {
            anim.SetBool("isPushing", false);
    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
            anim.SetFloat("Horizontal", vel.x);
            anim.SetFloat("Vertical", vel.y);
            anim.SetFloat("Speed", vel.sqrMagnitude);
            rb.MovePosition(rb.position + vel * Speed * Time.fixedDeltaTime);
            if (vel.x != 0 || vel.y != 0)
            {
            anim.SetBool("isMoving", true);
            anim.SetFloat("IdleDirH", vel.x);
                anim.SetFloat("IdleDirV", vel.y);
            }
            else if (vel.x == 0 && vel.y == 0)
            {
                anim.SetBool("isMoving", false);
            }
    }
    public void Move(InputAction.CallbackContext context)
    {
        vel = context.ReadValue<Vector2>();
    }

}




