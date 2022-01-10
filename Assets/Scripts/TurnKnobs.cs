using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//while r1 is held, left stick acts as 1:1 look rotation and right stick as updown 
public class TurnKnobs : MonoBehaviour
{
    private PlayerControls _controls;

    private readonly float _sensitivity_Y = 400f;
    private readonly float _sensitivity_X = 100f;
    private float _leftRightSpeed;
    private float _upDownSpeed;
    private float minimumSpeed = 0.1f;
    private float maxSpeed = 0.5f;

    private float _leftRightAngle = 0;
    private float _upDownAngle = 0;
    
    private Vector2 _currentLeftStickDirection;
    private Vector2 _previousLeftStickDirection;
    private Vector2 _currentRightStickDirection;
    private Vector2 _previousRightStickDirection;
    private float _lookX;
    private float _lookY;
    private bool _flicking = false;
    private Vector3 _flickFoward;
    private float _flickX;
    private float _flickY;
    private float _lastFlickX;
    private float _lastFlickY;
    private void Awake()
    {     
        _leftRightSpeed = minimumSpeed;
        _upDownSpeed = minimumSpeed;
        _flickFoward = transform.forward;
        var localEulerAngles = transform.localEulerAngles;
        _lookX = localEulerAngles.x;
        _lookY = localEulerAngles.y;
        _controls = new PlayerControls();

        _controls.CameraFixed.RightStick.performed += ctx => _currentRightStickDirection = ctx.ReadValue<Vector2>();
        _controls.CameraFixed.RightStick.canceled += ctx => _currentRightStickDirection = Vector2.zero;
        _controls.CameraFixed.LeftStick.performed += ctx => _currentLeftStickDirection = ctx.ReadValue<Vector2>(); 
        _controls.CameraFixed.LeftStick.canceled += ctx => _currentLeftStickDirection = Vector2.zero;
        
        //to speed triggers
        _controls.CameraFixed.R2.performed += ctx => _upDownSpeed = minimumSpeed + ctx.ReadValue<float>() * (maxSpeed - minimumSpeed);
        _controls.CameraFixed.R2.canceled += ctx => _upDownSpeed = minimumSpeed;
        _controls.CameraFixed.L2.performed += ctx => _leftRightSpeed = minimumSpeed + ctx.ReadValue<float>() * (maxSpeed - minimumSpeed);
        _controls.CameraFixed.L2.canceled += ctx => _leftRightSpeed = minimumSpeed;
        
        _previousLeftStickDirection = _currentLeftStickDirection;
        _previousRightStickDirection = _currentRightStickDirection;
    }


    public static float GetAngleOnAxis(Vector3 self, Vector3 other, Vector3 axis)
    {
        var perpendicularSelf = Vector3.Cross(axis, self);
        var perpendicularOther = Vector3.Cross(axis, other);
        return Vector3.SignedAngle(perpendicularSelf, perpendicularOther, axis);
    }
    
    private void OnEnable()
    {
        _controls.CameraFixed.Enable();
    }

    private void OnDisable()
    {
        _controls.CameraFixed.Disable();
    }
    private void Update()
    {
        var deltaLeftRight = Vector3.SignedAngle(_previousLeftStickDirection.normalized,
            _currentLeftStickDirection.normalized, Vector3.forward);
        var deltaUpDown = Vector3.SignedAngle(_previousRightStickDirection.normalized,
            _currentRightStickDirection.normalized, Vector3.forward);
        
        _leftRightAngle += -deltaLeftRight * _leftRightSpeed;
        _upDownAngle += deltaUpDown * _upDownSpeed;
        transform.localEulerAngles = new Vector3(_upDownAngle, _leftRightAngle, 0f);
        _previousLeftStickDirection = _currentLeftStickDirection;
        _previousRightStickDirection = _currentRightStickDirection;
    }
    
    
}