using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject.Find("Monster").GetComponent<Monster>().Dead();
            EventCenter.Instance.EventTrigger(E_EventType.E_Test);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = PoolMgr.Instance.GetObj("Test/Cube");
            obj.transform.position = Vector3.zero;
        }

        if (Input.GetMouseButtonDown(1))
        {
            PoolMgr.Instance.GetObj("Test/Sphere");
        }
    }
}
