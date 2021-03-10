using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlockMove : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D rb;

    public Animator anim;
    private Vector2 vel;

    private void Awake()
    {

    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        if (anim.GetBool("BlockMove"))
            {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            rb.MovePosition(rb.position + vel * Speed * Time.fixedDeltaTime);
            gameObject.tag = "Pusher";
        }
        else
        {
            gameObject.tag = "Pushable";
        }


    }
    public void Move(InputAction.CallbackContext context)
    {
            vel = context.ReadValue<Vector2>(); 
    }

}




