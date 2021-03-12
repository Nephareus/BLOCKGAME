using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Blocks : MonoBehaviour
{
    public float Speed = 5f;
    public Rigidbody2D rb;

    public Animator anim;
    public Collider2D col;
    public Collider2D coldistrigger;
    private Vector2 vel;
    public bool BMove;
    public bool PushDe;
    public bool PushDx;
    public bool PushDs;
    public bool disabletrig;
    public bool dyn;
    public bool PushDtrig;

    private void Awake()
    {

    }
    private void Update()
    {

    }

    private void FixedUpdate()
    {
        if (BMove == true)
        {
            if (anim.GetBool("BlockMove"))
            {
                if (dyn == true)
                {
                    gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
                rb.MovePosition(rb.position + vel * Speed * Time.fixedDeltaTime);
                gameObject.tag = "Pusher";
                //gameObject.tag = "Player";
                if (disabletrig == true)
                {
                    coldistrigger.enabled = false;
                }
            }
            else
            {
                gameObject.tag = "Pushable";
                coldistrigger.enabled = true;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (PushDe == true)
        {
            //if (other.gameObject.tag == "Player")
            if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
            {
                anim.SetBool("isPushing", true);
                if (PushDtrig == true)
                {
                    gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
                gameObject.tag = "Pusher";
                //coldistrigger.enabled = false;
            }
            //gameObject.tag = "Pusher";
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
        if (PushDx == true)
        {
            //if (other.gameObject.tag == "Player")
            if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
            {
                anim.SetBool("isPushing", false);
                if (PushDtrig == true)
                {
                    gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                }
                gameObject.tag = "Pushable";
                //coldistrigger.enabled = true;
            }
            //gameObject.tag = "Pushable";
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
        if (PushDs == true)
        {
            //if (other.gameObject.tag == "Player")
            if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pusher")
            {
                anim.SetBool("isPushing", true);
                if (PushDtrig == true)
                {
                    gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
                gameObject.tag = "Pusher";
                //coldistrigger.enabled = false;
            }
            //gameObject.tag = "Pusher";
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
    public void Move(InputAction.CallbackContext context)
    {
            vel = context.ReadValue<Vector2>();
    }
}
