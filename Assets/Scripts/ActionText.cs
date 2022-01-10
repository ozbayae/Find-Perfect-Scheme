using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ActionText : MonoBehaviour
{
    private PlayerInput _controls;
    private TextMeshProUGUI _actionLabel;

    private void Start()
    {
        Debug.Log("Test");
        Reload();
    }

    public void Reload()
    {
        bool found = false;
        if(_controls == null)
            Debug.Log("Where dem controls at?");
        foreach (var action in _controls.actions)
        {
            Debug.Log(action.name);
            Debug.Log(action.GetBindingDisplayString( ) + " : " + Translate(action.GetBindingDisplayString()));
            if (transform.parent.name == Translate(action.GetBindingDisplayString()))
            {
                _actionLabel.SetText(action.name);
                transform.GetChild(0).gameObject.SetActive(true);
                found = true;
            }
        }

        if (!found)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    private void Awake()
    {
        _controls = GameObject.FindWithTag("Player").GetComponent<PlayerInput>();
        _actionLabel = transform.GetComponentInChildren<TextMeshProUGUI>();
    }

    private string Translate(string binding)
    {
        Debug.Log("Translate" + binding);
        switch (binding)
        {
            case "A": return "Cross";
            case "B": return "Circle";
            case "X": return "Square";
            case "Y": return "Triangle";
            
            case "RB": return "R1";
            case "RT": return "R2";
            case "LB": return "L1";
            case "LT": return "L2";
            
            case "RS": return "RS";
            case "LS": return "LS";
            
            case "D-Pad Up": return "Up";
            case "D-Pad Down": return "Down";
            case "D-Pad Left": return "Left";
            case "D-Pad Right": return "Right";
            
            default: return "Unknown";
        }
    }
}
