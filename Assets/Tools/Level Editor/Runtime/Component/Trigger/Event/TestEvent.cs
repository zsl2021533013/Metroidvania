using UnityEngine;

namespace Level_Editor.Runtime.Event
{
    public class TestEvent : EventBase
    {
        public override void RegisterCallback(TriggerController controller)
        {
            Debug.Log(1);
        }
    }
}