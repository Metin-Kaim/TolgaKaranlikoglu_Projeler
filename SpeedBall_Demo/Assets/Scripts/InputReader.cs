using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    InputActions _inputActions;

    public float MoveDir { get; private set; }

    private void Awake()
    {
        _inputActions = new();
    }

    private void Start()
    {
        _inputActions.Player.Movement.Enable();
        _inputActions.Player.Movement.started += context => MoveDir = context.ReadValue<float>();

    }
}
