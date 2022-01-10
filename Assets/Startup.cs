using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitForResolutionChange());
    }

    IEnumerator WaitForResolutionChange()
    {
        yield return new WaitForSeconds(0.5f);
        LeanTween.moveY(gameObject, transform.position.y - 100, 1f).setEaseInOutCubic().setOnComplete(
            x =>
            {
                LeanTween.moveY(gameObject, transform.position.y + 100, 1f).setEaseInOutCubic().setDelay(5f).setOnComplete(Done);
            });
    }

    private void Done()
    {
        gameObject.SetActive(false);
    }
}
