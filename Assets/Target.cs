using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public delegate void ShotAction();
    public event ShotAction ShotDown;
    
    // Start is called before the first frame update
    private bool _down = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Projectile") && !_down)
        {
            LeanTween.rotateX(gameObject, 82, 0.3f).setEaseSpring().setOnComplete(Reset);
            _down = true;
            ShotDown?.Invoke();
        }
    }

    private void Reset()
    {
        LeanTween.rotateX(gameObject, 0, 1f).setEaseInOutCubic().setDelay(15f).setOnComplete(x => _down = false);
    }
}
