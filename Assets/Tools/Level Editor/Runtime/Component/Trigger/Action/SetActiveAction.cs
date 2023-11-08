using System;
using UnityEngine;

namespace Level_Editor.Runtime.Action
{
    [Serializable]
    public class SetActiveAction : ActionBase   
    {
        [SerializeField]
        private GameObject gameObject;
        [SerializeField]
        private bool state;
        
        public override void Perform()
        {
            Debug.Log(1);   
            // gameObject.SetActive(state);
        }
    }
}