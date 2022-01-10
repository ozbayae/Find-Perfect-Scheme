using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//while r1 is held, left stick acts as 1:1 look rotation and right stick as updown 
public class CameraFixed : MonoBehaviour
{
    private PlayerControls _controls;

    private readonly float _sensitivity_Y = 400f;
    private readonly float _sensitivity_X = 100f;
    private float _speed;
    private Vector2 _rotateDirection;
    private Vector2 _lookDirection;
    private Transform _player;
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
        _flickFoward = transform.forward;
        var localEulerAngles = transform.localEulerAngles;
        _lookX = 0f;
        _lookY = 0f;
        _player = GameObject.FindWithTag("Player").transform;
        _controls = new PlayerControls();

        _controls.CameraFixed.RightStick.performed += ctx => _lookDirection = ctx.ReadValue<Vector2>();
        _controls.CameraFixed.RightStick.canceled += ctx => _lookDirection = Vector2.zero;
        _controls.CameraFixed.LeftStick.performed += ctx => _rotateDirection = ctx.ReadValue<Vector2>();
        _controls.CameraFixed.RightStick.canceled += ctx => _rotateDirection = Vector2.zero;

        
        //listen to flicking
        _controls.CameraFixed.R1.started += OnFlicking;
        _controls.CameraFixed.R1.canceled += OnFlickingRelease;
        _flickX = localEulerAngles.x;
        _flickY = localEulerAngles.y;
        
    }

    private void OnFlicking(InputAction.CallbackContext ctx)
    {
        //remember lookY so we can snap back to same Y
        _flickX = _lookX;
        _flickY = _lookY;
        _flickFoward = new Vector3(_lookX, 0f, 0f);
        _flicking = true;
    }

    private void OnFlickingRelease(InputAction.CallbackContext ctx)
    {
        _flicking = false;
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
        var flicking = _flicking;
        Debug.Log("RightStick-  x: " + _lookDirection.x + "y: " + _lookDirection.y);
        Debug.Log("LeftStick-  x: " + _rotateDirection.x + "y: " + _rotateDirection.y);
        if (flicking)
        {
            // //forward vector based on Y rotation when flicking was started
            // var rotateDirection = new Vector3(_rotateDirection.x, _rotateDirection.y, 0f);
            // var lookDirection = new Vector2(-_lookDirection.y, _lookDirection.x);
            // rotateDirection.Normalize();
            // var rotation = Vector3.Angle(_flickFoward, rotateDirection);
            //
            // _lookX = 0f;
            // _lastFlickY = _flickY + rotation;
            // _lastFlickX = lookDirection.x * 45f;
            // var newRotation = Mathf.Atan2(rotateDirection.x, _rotateDirection.y) * Mathf.Rad2Deg;
            // transform.rotation = Quaternion.Euler(0f, Mathf.Atan2(rotateDirection.x, rotateDirection.y)*Mathf.Rad2Deg, 0f);
            // transform.localEulerAngles = new Vector3(_lastFlickX, transform.localEulerAngles.y, 0f);
            // _lookX = _lastFlickX;
            // _lookY = _lastFlickY;
            var rotate = new Vector2(_rotateDirection.y, _rotateDirection.x);
            Debug.Log(rotate);
            var deltaLeftRight = Vector3.SignedAngle(_flickFoward,
                rotate.normalized, Vector3.forward);
            var deltaUpDown = _flickFoward.y + _lookDirection.y * 45f;
            _lastFlickX = _flickFoward.x + deltaLeftRight;
            _lastFlickY = _flickFoward.y - deltaUpDown;
            transform.localEulerAngles = new Vector3(_lastFlickY, _lastFlickX, 0f);
            _lookX = _lastFlickX;
            _lookY = _lastFlickY;


        }
        else
        {
            Debug.Log("speed: " + _speed);
            var lookDirection = new Vector2(_lookDirection.x, _lookDirection.y);
            _lookX += lookDirection.x; //rotation around x axis = up-down
            _lookY += lookDirection.y; //rotation around y axis = around 
            _lookY = Mathf.Clamp(_lookY, -80f, 80f);
            transform.localEulerAngles = new Vector3(-_lookY, _lookX, 0f);
        }
        
    }
}