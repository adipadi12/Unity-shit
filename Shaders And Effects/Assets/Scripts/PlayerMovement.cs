using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        if (input.x > 0 || -input.x > 0)
        {
            rb.velocity = new Vector3(1,0,0) * input.x * 10f;
            Debug.Log("Pushin");
        }
        if (input.z > 0 || -input.z > 0) { 
            
            rb.velocity =new Vector3(0,0,1) * input.z * 10f;
        }
    }
}
