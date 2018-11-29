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

            animator.SetBool("jump", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);

        }
        else if (Input.GetKey(KeyCode.UpArrow)){

            transform.position += new Vector3(0, 0, 0.05f);
            animator.SetBool("walk_f", true);
            animator.SetBool("jump", false);
            animator.SetBool("walk_b", false);

        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            
            transform.position += new Vector3(0, 0, -0.05f);
            animator.SetBool("walk_b", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("jump", false);

        }else{

            animator.SetBool("jump", false);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);

        }
    }
}
