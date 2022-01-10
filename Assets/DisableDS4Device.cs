using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.DualShock;

public class DisableDS4Device : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var gamepads = Gamepad.all;
        foreach (var gamepad in gamepads)
        {
            if (gamepad.name == "DualShock4GamepadHID")
            {
                InputSystem.RemoveDevice(gamepad);
            }
        }
        //InputSystem.RemoveDevice(gamepad[0]);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
