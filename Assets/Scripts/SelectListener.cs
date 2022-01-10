using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class SelectListener : MonoBehaviour
{
    public Dropdown _dropdown;
    
    // Start is called before the first frame update
    void Start()
    {
        _dropdown.onValueChanged.AddListener(delegate(int arg0)
        {
            DropdownValueChanged(_dropdown);
        });
        GetComponent<CameraControl>().enabled = true;
    }


    void DropdownValueChanged(Dropdown change)
    {
        //how about a polymorphism instead of this shit
        //then you can remember the currently enabled child of ControlScheme
        //and just disable that
        switch (change.value)
        {
            case 0:
                GetComponent<CameraControl>().enabled = true;
                GetComponent<CameraFixed>().enabled = false;
                GetComponent<TurnKnobs>().enabled = false;
                break;
            case 1:
                GetComponent<CameraControl>().enabled = false;
                GetComponent<CameraFixed>().enabled = true;
                GetComponent<TurnKnobs>().enabled = false;
                break;
            default:
                GetComponent<CameraControl>().enabled = false;
                GetComponent<CameraFixed>().enabled = false;
                GetComponent<TurnKnobs>().enabled = true;
                break;
        }
    }
}
