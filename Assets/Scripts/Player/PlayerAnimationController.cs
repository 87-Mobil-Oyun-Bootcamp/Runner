using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;

    static int SPEED_HASH = Animator.StringToHash("Speed");
    static int SLIDE_HASH  = Animator.StringToHash("Slide");

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetSpeed(float speed)
    {
        animator.SetFloat(SPEED_HASH, speed);
    }

    public void TriggerSlide()
    {
        animator.SetTrigger(SLIDE_HASH);
    }
}
