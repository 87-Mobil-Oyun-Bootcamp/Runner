using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : Player
{
    public float speed = 1f;

    PlayerInputController inputController;
    PlayerMovementController movementController;
    PlayerAnimationController animationController;

    void Awake()
    {
        inputController = GetComponent<PlayerInputController>();
        movementController = GetComponent<PlayerMovementController>();
        animationController = GetComponent<PlayerAnimationController>();

        //inputController.OnSwiped += OnSwiped;  // Action<SwipeType> kullanıyor.
        inputController.OnSwiped.AddListener(OnSwiped); // UnityEvent<SwipeType> kullanıyor. 
    }

    private void Update()
    {
        animationController.SetSpeed(speed);
    }

    void OnSwiped(SwipeType swipeType)
    {
        movementController.OnSwiped(swipeType);

        if (swipeType == SwipeType.Down)
        {
            animationController.TriggerSlide();
        }
    }
}
