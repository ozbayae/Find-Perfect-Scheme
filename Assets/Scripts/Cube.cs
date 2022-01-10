using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Cube : MonoBehaviour
{
    private PlayerControls _controls;

    private Vector2 _move;
    private Vector2 _rotate;
    
    private void Awake()
    {
        _controls = new PlayerControls();
        var gameplayGrow = _controls.Gameplay.Grow;
        gameplayGrow.performed += ctx => Grow();

        _controls.Gameplay.Move.performed += ctx => _move = ctx.ReadValue<Vector2>();
        _controls.Gameplay.Move.canceled += ctx => _move = Vector2.zero;
        
        _controls.Gameplay.Rotate.performed += ctx => _rotate = ctx.ReadValue<Vector2>();
        _controls.Gameplay.Rotate.canceled += ctx => _rotate = Vector2.zero;
    }

    private void Grow()
    {
        transform.localScale *= 1.1f;
    }

    private void OnEnable()
    {
        _controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _controls.Gameplay.Disable();
    }
    private void Update()
    {
        var m = new Vector2(_move.x, _move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);

        var r = new Vector2(_rotate.y, -_rotate.x) * 100f * Time.deltaTime;
        transform.Rotate(r, Space.World);

    }
}
