using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Main : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // 同一帧调用显示某一个面板
        UIMgr.Instance.ShowPanel<BeginPanel>(E_UILayer.Middle, (panel) =>
        {
            print("第一次显示");
        },true);
        UIMgr.Instance.HidePanel<BeginPanel>();
        UIMgr.Instance.ShowPanel<BeginPanel>(E_UILayer.Middle, (panel) =>
        {
            print("第二次显示");
        }, true);
        UIMgr.Instance.GetPanel<BeginPanel>((panel) =>
        {
            print("获取面板要处理的逻辑");
        });
    }

    private void Update()
    {
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            UIMgr.Instance.ShowPanel<BeginPanel>(E_UILayer.System, (panel) =>
            {
                panel.TestFun();
            });
        }

        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            UIMgr.Instance.HidePanel<BeginPanel>(true);
        }

    }
}
