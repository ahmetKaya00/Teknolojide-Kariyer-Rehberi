using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isRotate", true);
            animator.SetBool("isPosition", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("isPosition", true);
            animator.SetBool("isRotate", false);
        }
        else
        {
            animator.SetBool("isRotate", false);
            animator.SetBool("isPosition", false);
        }
    }
}
