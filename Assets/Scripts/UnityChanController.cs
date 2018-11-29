using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            animator.SetBool("jumping", true);
            animator.SetBool("walking", false);

        }else if (Input.GetKey(KeyCode.UpArrow)){

            transform.position += new Vector3(0, 0, 0.5f);
            animator.SetBool("walking", true);
            animator.SetBool("jumping", false);

        }else if (Input.GetKey(KeyCode.DownArrow)){
            
            transform.position += new Vector3(0, 0, -0.5f);
            animator.SetBool("walking", true);
            animator.SetBool("jumping", false);

        }else{

            animator.SetBool("walking", false);
            animator.SetBool("jumping", false);

        }
    }
}
