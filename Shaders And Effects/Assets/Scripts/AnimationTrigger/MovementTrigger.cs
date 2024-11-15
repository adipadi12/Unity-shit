using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTrigger : MonoBehaviour
{
    public GameObject character;
    private Animator animator;

    private void Start()
    {
        animator = character.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Jump Bool", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Jump Bool", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("Slide Bool", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Slide Bool", false);
        }
    }
}
