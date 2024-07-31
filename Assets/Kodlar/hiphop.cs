using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SUPERCharacter;

public class hiphop : MonoBehaviour
{
   Animator animator;
    [SerializeField] SUPERCharacterAIO Controller;
private void Start()
{
    animator = GetComponent<Animator>();
}
private void Update()
{
    AnimatorStateInfo StateInfo = animator.GetCurrentAnimatorStateInfo(0);
    if (Input.GetKey(KeyCode.Q) && animator.GetFloat("Speed") < 0.3f)
    {
        animator.SetBool("hiphop", true);
        Controller.enableMovementControl = false;
        Controller.canJump = false;
    }
    else if (Input.GetKeyDown(KeyCode.E) && animator.GetFloat("Speed") < 0.3f)
    {
        if (StateInfo.IsName("Idle Walk Run Blend"))
        {
            animator.SetBool("sitting", true);
            Controller.enableMovementControl = false;
            Controller.canJump = false;
        } 
        else if(StateInfo.IsName("sitting"))
        {
            animator.SetBool("sitting", false);
            Controller.enableMovementControl = true;
            Controller.canJump = true;

        }
    }
    else if(!animator.GetBool("sitting"))
    {
        animator.SetBool("hiphop", false);
        Controller.enableMovementControl = true;
        Controller.canJump = true;
    }

}
}
