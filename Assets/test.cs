using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    private Vector2 m_Rotation;
    private Vector2 m_Look;
    private Vector2 m_Move;
    

    // Start is called before the first frame update
    public void Awake()
    {
        //jumpAction.performed += OnJump;
    }

    private void OnJump(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jumpy");
        if (ctx.started)
        {
            Debug.Log("started");
        } else if (ctx.performed)
        {
            Debug.Log("performed");
        } else if (ctx.canceled)
        {
            Debug.Log("canceled");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
