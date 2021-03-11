using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BlockMove : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D rb;

    public Animator anim;
    public Collider2D coltrigger;
    private Vector2 vel;
    public bool BMove;

    private void Awake()
    {

    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        if (BMove == true)
        {
            if (anim.GetBool("BlockMove"))
            {
                gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                rb.MovePosition(rb.position + vel * Speed * Time.fixedDeltaTime);
                //gameObject.tag = "Pusher";
                gameObject.tag = "Player";
                coltrigger.enabled = false;
            }
            else
            {
                gameObject.tag = "Pushable";
                coltrigger.enabled = true;
            }
        }
    }
    public void Move(InputAction.CallbackContext context)
    {
        if (BMove == true)
        {
            vel = context.ReadValue<Vector2>();
        }
    }
}




