using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAction : BaseAction
{
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        animator.SetBool("DamageTrigger", true);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
