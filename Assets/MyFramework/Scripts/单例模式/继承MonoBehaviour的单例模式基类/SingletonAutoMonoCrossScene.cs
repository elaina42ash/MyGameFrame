using UnityEngine;

/// <summary>
/// 自动创建式 MonoBehaviour 跨场景单例基类。
/// 适合不需要 Inspector 拖引用、纯代码型的管理器。
/// </summary>
public abstract class SingletonAutoMonoCrossScene<T> : MonoBehaviour where T : SingletonAutoMonoCrossScene<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = new GameObject(typeof(T).Name);
                instance = obj.AddComponent<T>();
                DontDestroyOnLoad(obj);
            }

            return instance;
        }
    }

    public static bool HasInstance
    {
        get { return instance != null; }
    }

    protected virtual void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = (T)this;
        DontDestroyOnLoad(gameObject);

        OnSingletonAwake();
    }

    protected virtual void OnSingletonAwake()
    {
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}