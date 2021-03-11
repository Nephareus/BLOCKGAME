using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D), typeof(Animator))]
public class PushDir : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D col;
    public Animator anim;
    public bool PushD;

    void Awake()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (PushD == true)
        {
            if (other.gameObject.tag == "Player")
            //if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
            {
                anim.SetBool("isPushing", true);
                gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                //gameObject.tag = "Pusher";
            }
            gameObject.tag = "Pusher";
        }
    }

    //{
    //if (other.gameObject.tag == "Player")
    //if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
    //{
    //anim.SetBool("isPushing", true);
    //gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    //gameObject.tag = "Pusher";
    //}
    //gameObject.tag = "Pusher";
    //}

    void OnTriggerExit2D(Collider2D other)
    {
        if (PushD == true)
        {
            //if (other.gameObject.tag == "Player")
            if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
            {
                anim.SetBool("isPushing", false);
                gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                //gameObject.tag = "Pushable";
            }
            gameObject.tag = "Pushable";
        }
    }

    //{
    //if (other.gameObject.tag == "Player")
    //if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
    //{
    //anim.SetBool("isPushing", false);
    //gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    //gameObject.tag = "Pushable";
    //}
    //gameObject.tag = "Pushable";
    //}

    void OnTriggerStay2D(Collider2D other)
    {
        if (PushD == true)
        {
            if (other.gameObject.tag == "Player")
            //if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
            {
                anim.SetBool("isPushing", true);
                gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                //gameObject.tag = "Pusher";
            }
            gameObject.tag = "Pusher";
        }
        //if (other.gameObject.tag == "Player")
        //if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
        //{
        //anim.SetBool("isPushing", true);
        //gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        //gameObject.tag = "Pusher";
        //}
        //gameObject.tag = "Pusher";
        //}
    }
}
