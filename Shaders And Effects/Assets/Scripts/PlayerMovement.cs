using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
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
        
            //        input.Normalize();
        rb.MovePosition(rb.position + input * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.MovePosition(new Vector3(0f, 5f, 0f) );
            Debug.Log("Jump");
        }
    }

    
}
