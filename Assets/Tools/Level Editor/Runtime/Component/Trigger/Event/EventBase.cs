using System;

namespace Level_Editor.Runtime.Event
{
    public interface IEvent
    {
        public void RegisterCallback(TriggerController controller);
    }
    
    [Serializable]
    public abstract class EventBase : IEvent
    {
        public abstract void RegisterCallback(TriggerController controller);
    }
}