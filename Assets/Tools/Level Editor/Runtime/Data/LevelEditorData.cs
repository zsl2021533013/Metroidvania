using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Level_Editor.Runtime
{
    [Serializable]
    public class LevelEditorData : SerializedScriptableObject
    {
        public List<LevelData> levelDatas = new List<LevelData>();
    }
}