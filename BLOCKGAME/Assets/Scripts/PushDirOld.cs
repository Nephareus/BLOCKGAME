using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PushDirOld : MonoBehaviour
{
    public Rigidbody2D rb;
    public Collider2D col;

    void Awake()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //if (col.GetComponent<Collider2D>().attachedRigidbody)
            //    col.GetComponent<Collider2D>().attachedRigidbody.bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //if (col.GetComponent<Collider2D>().attachedRigidbody)
            //    col.GetComponent<Collider2D>().attachedRigidbody.bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            //if (col.GetComponent<Collider2D>().attachedRigidbody)
            //    col.GetComponent<Collider2D>().attachedRigidbody.bodyType = RigidbodyType2D.Dynamic;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
