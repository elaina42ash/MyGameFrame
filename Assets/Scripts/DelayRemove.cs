using System;
using UnityEngine;

public class DelayRemove : MonoBehaviour
{
    public string poolName;
    private void OnEnable()
    {
        Invoke("RemoveMe", 1.0f);
    }

    private void RemoveMe()
    {
        PoolMgr.Instance.PushObj(this.gameObject);
    }
}
