using System;
using UnityEngine;

public class Other : MonoBehaviour
{
    private void Awake()
    {
        EventCenter.Instance.AddEventListener<Monster>(E_EventType.E_Monster_dead, OtherWaitMonsterDeadDo);
    }

    public void OtherWaitMonsterDeadDo(Monster info)
    {
        Debug.Log("其他相关处理" + info.monsterID);
    }

    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener<Monster>(E_EventType.E_Monster_dead, OtherWaitMonsterDeadDo);
    }
}
