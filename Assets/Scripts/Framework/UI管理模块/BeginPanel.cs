using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BeginPanel : BasePanel
{
    private void Start()
    {
        UIMgr.AddCustomEventListener(GetControl<Button>("btnBegin"),EventTriggerType.PointerEnter, (data) =>
        {
            print("鼠标进入");
        });
        UIMgr.AddCustomEventListener(GetControl<Button>("btnBegin"), EventTriggerType.PointerExit, (data) =>
        {
            print("鼠标离开");
        });

        EventCenter.Instance.AddEventListener<float>(E_EventType.E_SceneLoadChange,ChangeScene);
    }


    private void ChangeScene(float p)
    {
        print("切换场景的进度" + p);
    }

    public override void ShowMe()
    {
        
    }

    public override void HideMe()
    {
    }

    protected override void ClickBtn(string btnName)
    {
        switch (btnName)
        {
            case "btnBegin":
                print("开始按钮被点击");
                SceneMgr.Instance.LoadSceneAsyn("Test", () =>
                {
                    print("场景加载结束");
                });
                break;
            case "btnSetting":
                print("设置按钮被点击");
                break;
            case "btnQuit":
                print("退出按钮被点击");
                break;
        }
    }
}
