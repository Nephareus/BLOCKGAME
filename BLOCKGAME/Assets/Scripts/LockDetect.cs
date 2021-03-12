using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDetect : MonoBehaviour
{
    public Animator anim;
    public Animator animref;
    void FixedUpdate()
    {
        if (animref.GetBool("isUnlocked"))
            {
            anim.SetBool("LockDetect", false);
            gameObject.tag = "Pushable";
        }
        else
        {
            anim.SetBool("LockDetect", true);
            gameObject.tag = "Pusher";
        }

    }
}
