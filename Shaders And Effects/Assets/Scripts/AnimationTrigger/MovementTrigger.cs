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
            StartCoroutine(JumpAnimation(animator, "Jump Bool", animator.GetCurrentAnimatorClipInfo(0)[0].clip.length));
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Jump Bool", false);
        }
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    animator.SetBool("Slide Bool", true);
        //    StartCoroutine( SlideAnimation(animator, "Slide Bool", animator.GetCurrentAnimatorClipInfo(0)[0].clip.length)); // passes size of the animation clip as an argument
        //}
        //if (Input.GetKeyUp(KeyCode.S))
        //{
        //    animator.SetBool("Slide Bool", false);
        //}
        if(Input.GetKeyDown (KeyCode.S))
        {
            animator.Play("Slide");
        }
    }

    private IEnumerator SlideAnimation(Animator animator, string boolName, float animationLength)
    {
        yield return new WaitForSeconds(animationLength);
        animator.SetBool(boolName, false);
    }

    private IEnumerator JumpAnimation(Animator animator, string boolName, float animLen)
    {
        yield return new WaitForSeconds(animLen);
        animator.SetBool(boolName, false);
    }
    
}
