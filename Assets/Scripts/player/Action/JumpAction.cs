using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAction : BaseAction
{
    private Animator animator;
    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Cindy_Jump_up");
            rigidBody2D.AddForce(Vector2.up * 6, ForceMode2D.Impulse);
        }

    }
}
