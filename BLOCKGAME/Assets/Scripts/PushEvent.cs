using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Collider2D))]
public class PushEvent : MonoBehaviour
{

    public Animator anim;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            {
                anim.SetBool("isPushing", true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            {
                anim.SetBool("isPushing", false);
            }
        }

    }
}


