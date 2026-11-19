using System.Security.Cryptography;
using UnityEngine;

public class HelloLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    //     Debug.Log("你好，我来自 gamelogic.dll");

    //     string assemblyName = typeof(HelloLogic).Assembly.GetName().Name;
    //     Debug.Log("我所在的程序集是:"+assemblyName);
    // }
    public void SayHello()
    {
        // Debug.Log("成功反射调用了。SayHello");
        Debug.Log("成功调用第二版字节流方法反射");
    }
}
