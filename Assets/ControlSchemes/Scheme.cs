using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace ControlSchemes
{
    [Serializable]
    public struct ActionButton
    {
        public string button; //one of Buttons.cs
        public string action; //one of Actions.cs
    }
    
    [Serializable]
    public struct ActionHint
    {
        public string button;
        public string hint;
    }
    
    [Serializable]
    public class Scheme
    {
        public string title;
        public string description;
        public List<ActionButton> buttons; //which actions have which button(s?)
        public List<ActionHint> hints; //Customized hints for actions
    }
}
