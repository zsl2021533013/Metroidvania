using System;
using System.Collections.Generic;
using System.Linq;
using Level_Editor.Runtime.Action;
using Level_Editor.Runtime.Event;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
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
        #region Main Property

        [Space(5)]
        [SerializeReference, LabelText("Events")]
        public List<EventBase> triggerEvents;

        [Space(5)]
        [SerializeReference, LabelText("Conditions")]
        public List<ConditionBase> triggerConditions;

        [Space(5)]
        [SerializeReference, LabelText("Actions")]
        public List<ActionBase> triggerActions;

        #endregion
        
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

        #region Callback

        public Action<TriggerState> onStateChanged;

        #endregion
        

        private void Awake()
        {
            triggerEvents.ForEach(@event =>  @event.RegisterCallback(this));
        }

        public void TryTrigger()
        {
            if (triggerConditions.All(condition => condition.Satisfied()))
            {
                triggerActions.ForEach(action => action.Perform());
            }
        }
    }
}
