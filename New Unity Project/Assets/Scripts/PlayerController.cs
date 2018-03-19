using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {



    public float speed;
    AudioSource source;
    AudioClip sound;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.black;
           
        }
        else if (col.gameObject.name == "Cube (2)")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.grey;

        }
        else if (col.gameObject.name == "Cube (3)")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;

        }
        else if (col.gameObject.name == "Cube (4)")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.green;

        }
        else if (col.gameObject.name == "Cube (5)")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.magenta;

        }
        else if (col.gameObject.name == "Cube (6)")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.blue;

        }
        else if (col.gameObject.name == "Cube (7)")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

        }


    }
}
