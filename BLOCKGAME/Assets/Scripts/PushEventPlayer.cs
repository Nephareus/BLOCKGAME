using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Collider2D))]
public class PushEventPlayer : MonoBehaviour
{

    public Animator anim;


    void OnTriggerEnter2D(Collider2D other)
    {
            {
                anim.SetBool("isPushing", true);
            }
    }

    void OnTriggerExit2D(Collider2D other)
    {
            {
                anim.SetBool("isPushing", false);
            }
    }
}


