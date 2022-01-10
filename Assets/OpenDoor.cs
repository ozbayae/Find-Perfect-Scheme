using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private Interactable button;

    private bool _closed = true;
    public void OnEnable()
    {
        button.Interacted += Open;
    }

    private void Open()
    {
        if (_closed)
        {
            _closed = false;
            GameObject door = transform.GetChild(0).gameObject;
            LeanTween.moveLocalZ(door, door.transform.localPosition.z + 7, 1f).setOnComplete(Close);
        } 
    }

    private void Close()
    {
        GameObject door = transform.GetChild(0).gameObject;
        LeanTween.moveLocalZ(door, door.transform.localPosition.z - 7, 1f).setDelay(5f).setOnComplete(x => _closed = true);
        
    }
    
    
}
