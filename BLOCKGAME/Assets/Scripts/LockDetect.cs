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
        }
        else
        {
            anim.SetBool("LockDetect", true);
        }

    }
}
