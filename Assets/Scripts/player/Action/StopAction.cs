using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAction : BaseAction
{
    private Animator animator;

    bool isStop;

    void Start()
    {
        animator = GetComponent<Animator>();
 
        isStop = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isStop == false)
        {
            isStop = true;
            animator.SetBool("StopTrigger", true);

            GameSystem.Stop();
        }

        if (Input.GetKeyUp(KeyCode.Space) && isStop == true)
        {
            isStop = false;
            animator.SetBool("StopTrigger", false);

            GameSystem.Restart();
        }
    }
}
