﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeftyHarryMovement : CharacterMovement
{
    protected override void Awake()
    {
        base.Awake();
        speed = 1.0f;
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override bool GetIsGrounded()
    {
        return base.GetIsGrounded();
    }

    public override Vector3 GetVelocity()
    {
        return base.GetVelocity();
    }

    public override void Jump(float jumpForce_)
    {
        base.Jump(jumpForce_);
    }

    protected override void OnTriggerEnter(Collider collision)
    {
        base.OnTriggerEnter(collision);
    }

    public override void SetCanMove()
    {
        base.SetCanMove();
    }

    public override void SetIsGrounded(bool isGrounded_)
    {
        base.SetIsGrounded(isGrounded_);
    }

    public override void SetVelocity(Vector3 velocity_)
    {
        base.SetVelocity(velocity_);
    }

    protected override void Start()
    {
        base.Start();
    }

    
} 