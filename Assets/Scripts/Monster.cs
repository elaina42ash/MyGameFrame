using UnityEngine;

public class Monster : MonoBehaviour
{
    public string monsterName = "123123";
    public int monsterID = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Dead();
    }

    public void Dead()
    {
        Debug.Log("怪物死亡了");
        // 其他对象在怪物死亡时候想做的事
        EventCenter.Instance.EventTrigger<Monster>(E_EventType.E_Monster_dead,this);
    }
}
