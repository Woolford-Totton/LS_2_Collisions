using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Input_Collisions : MonoBehaviour
{
    [SerializeField]
    private float Movespeed;

    private Vector3 movedirection;


    // Start is called before the first frame update
    void Start()
    {
        Movespeed = 0.1f;
        movedirection = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontalpress = Input.GetAxis("Horizontal");

        float Verticalpress = Input.GetAxis("Vertical");

        float finalmovespeed = Movespeed * Time.deltaTime;

        movedirection.Set(Horizontalpress * Movespeed, 0, Verticalpress * Movespeed);       

        transform.Translate(movedirection);
    }
    private void OnCollisionEnter(Collision collision)
    {
       //do some code here on collision
    }
    private void OnTriggerEnter(Collider other)
    {
       //do some code here on collision
    }
}
