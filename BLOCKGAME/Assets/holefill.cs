using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody2D), typeof(Collider2D), typeof(Animator))]

public class holefill : MonoBehaviour
{
    public Collider2D col;
    public Animator anim;
    public Rigidbody2D rb;
    public Collider2D coldis1;
    public Collider2D coldis2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (anim.GetBool("holefilled"))
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
            else if (other.gameObject.tag == "Pushable" || other.gameObject.tag == "Pusher")
        {
            Destroy(other.gameObject);
            anim.SetBool("holefilled", true);
            coldis1.enabled = false;
            coldis2.enabled = false;
        }
        else if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (anim.GetBool("holefilled"))
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        } 
            else if (other.gameObject.tag == "Pushable" || other.gameObject.tag == "Pusher")
        {
            Destroy(other.gameObject);
            anim.SetBool("holefilled", true);
            coldis1.enabled = false;
            coldis2.enabled = false;
        }
        else if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (anim.GetBool("holefilled"))
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
        else if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
}
