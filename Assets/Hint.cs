using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hint : MonoBehaviour
{
    [SerializeField] private string hint;
    [SerializeField] string action;
    private PlayerInput _input;
    //private TextMeshProUGUI _hintUI;
    private GameObject _hintUI;

    private float hintHeight = 250;

    private void Awake()
    {
        _input = GameObject.FindWithTag("Player").GetComponent<PlayerInput>();
        _hintUI = GameObject.FindWithTag("Hint");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _hintUI.GetComponent<TextMeshProUGUI>().text = hint + " " + Translate(_input.actions[action].GetBindingDisplayString());
            LeanTween.moveY(_hintUI, hintHeight, 0.5f).setEaseInOutCubic();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //_hintUI.GetComponent<TextMeshProUGUI>().text = "";
        LeanTween.moveY(_hintUI.GetComponent<RectTransform>(), -400f, 0.5f).setEaseInOutCubic();
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
