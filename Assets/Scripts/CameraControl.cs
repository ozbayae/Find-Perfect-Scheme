using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    private PlayerControls _controls;

    private readonly float _minimumSpeed = 0.1f;
    //private readonly float _bigSensitivity = 300f;
    private readonly float _maxMultiplier = 4f;
    private float _multiplier;
    
    private readonly float _smallSensitivity = 25f;
    private float _speed;
    private Vector2 _direction;
    private Transform _player;
    private float _lookX;
    private float _lookY;

    private bool _normalizeDirection = false;

    private void Awake()
    {
        var localEulerAngles = transform.localEulerAngles;
        _lookX = localEulerAngles.x;
        _lookY = localEulerAngles.y;
        _player = GameObject.FindWithTag("Player").transform;
        _controls = new PlayerControls();

        _controls.Camera.Speed.performed += ctx => _speed = ctx.ReadValue<float>();
        _controls.Camera.Speed.canceled += ctx => _speed = 0f;

        _controls.Camera.Direction.performed += ctx => _direction = ctx.ReadValue<Vector2>();
        _controls.Camera.Direction.canceled += ctx => _direction = Vector2.zero;

        _controls.Camera.Multiplier.performed += ctx => _multiplier = ctx.ReadValue<float>();
        _controls.Camera.Multiplier.canceled += ctx => _multiplier = 0f;
    }

    private void OnEnable()
    {
        _controls.Camera.Enable();
    }

    private void OnDisable()
    {
        _controls.Camera.Disable();
    }
    private void Update()
    {
        //Debug.Log("speed: " + _speed);
        var direction = new Vector2(-_direction.y, _direction.x);
        if(_normalizeDirection) direction.Normalize();
        var currentSpeed = _minimumSpeed + _speed * _smallSensitivity * Time.deltaTime;
        var currentMultiplier = 1 + _multiplier * (_maxMultiplier - 1);
        currentSpeed *= currentMultiplier;
        _lookX += direction.x * currentSpeed;
        _lookY += direction.y * currentSpeed;
        _lookX = Mathf.Clamp(_lookX, -80f, 80f);
        transform.localEulerAngles = new Vector3(_lookX, _lookY, 0f);
    }
}