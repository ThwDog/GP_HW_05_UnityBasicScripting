using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField]
    public Rigidbody rb;
    public int speed;
    public int j;
    [SerializeField]
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //cam.position = rb.position;
        cam.transform.parent = rb.transform;
    }

    // Update is called once per frame
    void Update()
    {
        move();

    }
    void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
            //print("w");
            Debug.Log("w");
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = transform.up * j;
        } 
    }

    
}
