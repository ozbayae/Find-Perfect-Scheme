using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    [Serializable]
    public class NameToHighlight
    {
        public string name;
        public GameObject highlight;
    }
    public List<NameToHighlight> highlightMapping;

    public void HighlightButton(string button)
    {
        var highlightTarget = highlightMapping.Find(x => x.name == button).highlight;
        highlightTarget.SetActive(true);
    }

    public void UnHighlightButton(string button)
    {
        var highlightTarget = highlightMapping.Find(x => x.name == button).highlight;
        highlightTarget.SetActive(false);
    }
    
}
