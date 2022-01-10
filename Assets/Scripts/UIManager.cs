using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button info;
    // Start is called before the first frame update
    void Start()
    {
        info.onClick.AddListener(delegate
        {
            ButtonClicked(info);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ButtonClicked(Button btn)
    {
        
    }
}
