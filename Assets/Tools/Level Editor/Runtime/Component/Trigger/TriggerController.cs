using System;
using Level_Editor.Runtime.Action;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Level_Editor.Runtime
{
    public enum TriggerState
    {
        Untriggered,
        Triggering,
        Triggered
    }
    
    public class TriggerController : MonoBehaviour
    {
        private TriggerState _state = TriggerState.Untriggered;
        
        public TriggerState State
        {
            get
            {
                return _state;
            }
            set
            {
                if (value != _state)
                {
                    onStateChanged?.Invoke(_state);
                    _state = value;
                }
            }
        }

        public Action<TriggerState> onStateChanged;

        public ConditionBase condition;

        public ActionBase action;

        public void TryTrigger()
        {
            if (condition.Satisfied())
            {
                action.Perform();
                State = TriggerState.Triggered;
            }
        }
    }
}
