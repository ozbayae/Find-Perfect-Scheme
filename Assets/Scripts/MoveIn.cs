using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveIn : MonoBehaviour
{
    public LeanTweenType inType;
    private void OnEnable()
    {
        var width = GetComponent<RectTransform>().rect.width;
        transform.localPosition = transform.localPosition + new Vector3(width, 0, 0);
        LeanTween.moveLocalX(gameObject, transform.localPosition.x - width, 0.25f).setDelay(0.4f).setEase(inType);
    }

    public void OnClose()
    {
        var width = GetComponent<RectTransform>().rect.width;
        LeanTween.moveLocalX(gameObject, transform.localPosition.x + width, 0.25f).setDelay(0.4f).setEase(inType)
            .setOnComplete(OnCloseFinished);
        
    }

    public void OnSwitch(string controlScheme)
    {
        GameObject.FindWithTag("Player").GetComponent<PlayerInput>().SwitchCurrentControlScheme(controlScheme);
        var labels = GameObject.FindGameObjectsWithTag("ButtonLabel");
        var width = GetComponent<RectTransform>().rect.width;
        LeanTween.moveLocalX(gameObject, transform.localPosition.x + width, 0.25f).setDelay(0.4f).setEase(inType)
            .setOnComplete(x =>
            {
                foreach (var label in labels)
                {
                    label.GetComponent<ActionText>().Reload();
                }
                LeanTween.moveLocalX(gameObject, transform.localPosition.x - width, 0.25f).setDelay(0.4f).setEase(inType);
            });
    }

    private void OnCloseFinished()
    {
        var width = GetComponent<RectTransform>().rect.width;
        transform.localPosition = transform.localPosition - new Vector3(width, 0, 0);
        gameObject.SetActive(false);
    }
}
