using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Collider2D), typeof(Animator))]

public class locker : MonoBehaviour
{
    public Animator anim;
    public Animator animref;
    public Collider2D col;

    void Awake()
    {
        anim.SetBool("isUnlocked", true);
    }

    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (animref.GetBool("BlockMove"))
        {
            if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher" || other.gameObject.tag == "Pushable")
            {
                anim.SetBool("isUnlocked", true);
                animref.SetBool("BlockMove", false);
            }
        }
        else if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher" || other.gameObject.tag == "Pushable")
        {
            anim.SetBool("isUnlocked", false);
            animref.SetBool("BlockMove", true);
        }
    }

 //   void OnTriggerExit2D(Collider2D other)
 //   {
 //       if (animref.GetBool("BlockMove"))
 //       {
 //           if (other.gameObject.tag == "Player")
 //           {
 //               anim.SetBool("isUnlocked", true);
 //               animref.SetBool("BlockMove", false);
 //           }
 //       }
//        else if (other.gameObject.tag == "Player")
//        {
//            anim.SetBool("isUnlocked", false);
//            animref.SetBool("BlockMove", true);
//        }
//    }
}