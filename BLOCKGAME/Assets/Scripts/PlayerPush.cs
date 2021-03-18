using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pushable" || other.gameObject.tag == "Pusher")
        {
            anim.SetBool("isPushing", true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pushable" || other.gameObject.tag == "Pusher")
        {
            anim.SetBool("isPushing", false);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pushable" || other.gameObject.tag == "Pusher")
        {
            anim.SetBool("isPushing", true);
        }
    }
}