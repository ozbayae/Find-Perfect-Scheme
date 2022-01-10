using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public enum Side
{
    //which side the line comes from
    Bottom,
    Left,
    Top,
    Right
}
public class Line : MonoBehaviour
{
    public Image prefabLine;
    public Transform target;
    public Side side = Side.Top;

    
    IEnumerator WaitUntilEndOfFrame()
    {
        yield return new WaitForEndOfFrame();
        //Do your stuff
        if (!target)
            target = transform.parent.parent;
        var myPosition = transform.position;
        var targetPosition = target.position;
        var rect = GetComponent<RectTransform>().rect;
        //Debug.Log(rect.width);
        //Debug.Log(rect.height);
        switch (side)
        {
            case Side.Bottom:
                DrawLine(new Vector2(myPosition.x, myPosition.y - rect.height / 2),
                    new Vector2(targetPosition.x, targetPosition.y));
                break;
            case Side.Left:
                DrawLine(new Vector2(myPosition.x - rect.width / 2, myPosition.y),
                    new Vector2(targetPosition.x, targetPosition.y));
                break;
            case Side.Top:
                DrawLine(new Vector2(myPosition.x, myPosition.y + rect.height / 2),
                    new Vector2(targetPosition.x, targetPosition.y));
                break;
            case Side.Right:
                DrawLine(new Vector2(myPosition.x + rect.height, myPosition.y),
                    new Vector2(targetPosition.x, targetPosition.y));
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

    }
    public void Start()
    {
        StartCoroutine(WaitUntilEndOfFrame());
    }

    public void OnEnable()
    {
        if(transform.childCount == 3)
            Destroy(transform.GetChild(2).gameObject); //destroy line on reload
        Start();
    }

    private void DrawLine(Vector2 pointA, Vector2 pointB)
    {
        const float lineWidth = 2;
        Vector3 differenceVector = pointB - pointA;
        var line = Instantiate(prefabLine, GetComponent<Transform>());
        var imageRectTransform = line.GetComponent<RectTransform>();
        imageRectTransform.sizeDelta = new Vector2( differenceVector.magnitude, lineWidth);
        imageRectTransform.pivot = new Vector2(0, 0.5f);
        imageRectTransform.position = pointA;
        float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
        imageRectTransform.rotation = Quaternion.Euler(0,0, angle);
    }
}
