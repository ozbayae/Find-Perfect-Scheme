using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class NormalHint : MonoBehaviour
{
    [SerializeField] private string hint;
    //private TextMeshProUGUI _hintUI;
    private GameObject _hintUI;

    private float hintHeight = 250;

    private void Awake()
    {
        _hintUI = GameObject.FindWithTag("Hint");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _hintUI.GetComponent<TextMeshProUGUI>().text = hint;
            LeanTween.moveY(_hintUI, hintHeight, 0.5f).setEaseInOutCubic();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //_hintUI.GetComponent<TextMeshProUGUI>().text = "";
        LeanTween.moveY(_hintUI.GetComponent<RectTransform>(), -400f, 0.5f).setEaseInOutCubic();
    }
    
}