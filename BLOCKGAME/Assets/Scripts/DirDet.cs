using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirDet : MonoBehaviour
{
    public Animator anim;
    public Animator animref;
    private Vector2 vel;
    private int absx;
    private int absy;
    public bool owr;
    public bool owl;
    public bool owu;
    public bool owd;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        //if (vel.x != 0 || vel.y != 0)
        //anim.SetFloat("Horizontal", vel.x);
        //anim.SetFloat("Vertical", vel.y);
        //animref.SetBool("Moveable", false);
        vel.x = anim.GetFloat("Horizontal");
        vel.y = anim.GetFloat("Vertical");
        absx = (int)Mathf.Abs(vel.x);
        absy = (int)Mathf.Abs(vel.y);
        if (owr == true){
            if (vel.x > 0 && absx > absy)
            {
                animref.SetBool("Moveable", true);
            }
            else
            {
                animref.SetBool("Moveable", false);
            }
        }
        if (owl == true){
            if (vel.x < 0 && absx > absy)
            {
                animref.SetBool("Moveable", true);
            }
            else
            {
                animref.SetBool("Moveable", false);
            }
        }
        if (owu == true){
            if (vel.y > 0 && absx < absy)
            {
                animref.SetBool("Moveable", true);
            }
            else
            {
                animref.SetBool("Moveable", false);
            }
        }
        if (owd == true){
            if (vel.y < 0 && absx < absy)
            {
                animref.SetBool("Moveable", true);
            }
            else
            {
                animref.SetBool("Moveable", false);
            }
        }
    }
}
