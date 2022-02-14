using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_input : MonoBehaviour
{
    private float movespeed=0.01f;
    private bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("w") | Input.GetKey("up"))
        //{
        //    transform.Translate(0, movespeed, 0);
        //}

        //if (Input.GetKey("s") | Input.GetKey("down"))
        //{
        //    transform.Translate(0, -movespeed, 0);
        //}

        if (Input.GetKey("a") | Input.GetKey("left"))
        {

            
            transform.Translate(-movespeed, 0, 0);
        }
        if (grounded == false)
        {
            transform.Translate(0, -0.05f, 0) ;
        }
        if (Input.GetKey("d") | Input.GetKey("right"))
        {
            transform.Translate(movespeed,0, 0);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="cube")
        { 
            
        }
        if (other.gameObject.transform.tag == "ground")
        {
            grounded = true;
            
            //Do what you want when it collided with the ground
        }
        else
        {
            //Do something else
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.transform.tag == "ground")
    //    {
    //        grounded = true;

    //        //Do what you want when it collided with the ground
    //    }
    //    else
    //    {
    //        //Do something else
    //    }
    //}

}
