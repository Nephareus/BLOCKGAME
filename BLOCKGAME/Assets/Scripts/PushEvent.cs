using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator), typeof(Collider2D))]
public class PushEvent : MonoBehaviour
{
    public Animator anim;
    private Vector2 vel;
    private void Awake()
        {
            anim.SetBool("isPushing", false);
        }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
                anim.SetBool("isPushing", true);
        }
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
                    anim.SetBool("isPushing", false);
        }
    }


    public void Move(InputAction.CallbackContext context)
    {
        vel = context.ReadValue<Vector2>();
    }
}
