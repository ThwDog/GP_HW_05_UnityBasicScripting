using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cubeMove();
    }

    void cubeMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(0, 2, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(-2, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(2, 0, 0);
        }
    }
}
