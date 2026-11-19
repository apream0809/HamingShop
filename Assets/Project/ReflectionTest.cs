using UnityEngine;
using System;
using System.Reflection;

public class ReflectionTest : MonoBehaviour
{
    private void Start()
    {
        Type type=Type.GetType("HelloLogic,GameLogic");
        if(type==null)
        {
            Debug.LogError("没有找到hellologic类");
            return;
        }

        MethodInfo method = type.GetMethod("SayHello",BindingFlags.Public|BindingFlags.Static);
        if (method == null)
        {
            Debug.LogError("不存在这个方法");
            return;
        }

        method.Invoke(null,null);
    }
}