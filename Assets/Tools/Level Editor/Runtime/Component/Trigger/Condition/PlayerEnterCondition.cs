using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Level_Editor.Runtime
{
    [Serializable]
    public class PlayerEnterCondition : ConditionBase
    {
        public Collider collider;
        
        public override bool Satisfied()
        {
            return false;
        }
    }
}