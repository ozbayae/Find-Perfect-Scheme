using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideIn : MonoBehaviour
{
    public LeanTweenType inType;
    private void OnEnable()
    {
        transform.localScale = new Vector3(0, 1, 1);
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.25f).setDelay(0.1f).setEase(inType);
    }
}
