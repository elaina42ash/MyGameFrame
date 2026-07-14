using UnityEngine;

/// <summary>
/// 手动挂载式 MonoBehaviour 跨场景单例基类。
/// 适合需要在 Inspector 中拖引用、配置参数的管理器。
/// </summary>
public abstract class SingletonMonoCrossScene<T> : MonoBehaviour where T : SingletonMonoCrossScene<T>
{
    private static T instance;

    public static T Instance
    {
        get { return instance; }
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