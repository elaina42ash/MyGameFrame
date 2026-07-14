using System;
using System.Reflection;
using UnityEngine;

/// <summary>
/// 普通 C# 管理器单例基类。
/// 不适用于 MonoBehaviour。
/// 子类必须提供 private 或 protected 的无参构造函数。
/// </summary>
public abstract class Singleton<T> where T : Singleton<T>
{
    private static T instance;
    private static readonly object lockObj = new object();

    public static T Instance
    {
        get
        {
            if (instance != null)
                return instance;

            lock (lockObj)
            {
                if (instance != null)
                    return instance;

                Type type = typeof(T);

                ConstructorInfo constructorInfo = type.GetConstructor(
                    BindingFlags.Instance | BindingFlags.NonPublic,
                    null,
                    Type.EmptyTypes,
                    null
                );

                if (constructorInfo == null)
                {
                    throw new Exception($"{type.Name} 必须声明 private 或 protected 的无参构造函数。");
                }

                instance = constructorInfo.Invoke(null) as T;

                if (instance == null)
                {
                    throw new Exception($"{type.Name} 单例实例创建失败。");
                }

                return instance;
            }
        }
    }

    public static T GetInstance()
    {
        return Instance;
    }
}