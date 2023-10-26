using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEngine;
using Object = System.Object;

namespace Level_Editor.Runtime
{
    [Serializable]
    public class TriggerCompleteCondition : ConditionBase
    {
        [OnCollectionChanged(after: "AfterListChanged")]
        public List<TriggerController> triggers = new List<TriggerController>();
        
        private void AfterListChanged(CollectionChangeInfo info, Object value)
        {
            var triggerController = value as TriggerController;
            if (triggerController == null)
            {
                return;
            }
            
            if (info.ChangeType == CollectionChangeType.Add)
            {
                triggerController.onStateChanged += OnStateChanged;
            }

            if (info.ChangeType == CollectionChangeType.RemoveIndex)
            {
                triggerController.onStateChanged -= OnStateChanged;
            }
        }

        public void OnStateChanged(TriggerState state)
        {
            Satisfied();
        }

        public override bool Satisfied()
        {
            return triggers.All(trigger => trigger.State == TriggerState.Triggered);
        }
    }
}