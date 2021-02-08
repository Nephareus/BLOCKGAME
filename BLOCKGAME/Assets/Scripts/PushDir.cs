using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(EdgeCollider2D))]
public class PushDir : MonoBehaviour
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
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
    void OnTriggerExit2D(Collider2D col)
    {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }
    void OnTriggerStay2D(Collider2D col)
    {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
