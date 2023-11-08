using System;
using Sirenix.OdinInspector;
using UnityEngine;

public class Test : SerializedMonoBehaviour
{
    [Serializable]
    public class A
    {
        public string s;
    }

    [Serializable]
    public class B : A
    {
        public string t;
    }

    [HideLabel]
    [SerializeReference]
    [HideReferenceObjectPicker]
    public A a = new B();

    private void Awake()
    {
        var aa = (B)a;
        
        Debug.Log(aa.s);
        Debug.Log(aa.t);
    }
}
