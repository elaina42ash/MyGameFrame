using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class Main : MonoBehaviour
{
    private void Start()
    {
        Vector3 src = new Vector3(1, 5, 0);
        Vector3 target = new Vector3(0, 19, 1);
        print(MathUtil.GetObjDistanceXZ(src,target));

        if (MathUtil.CheckObjDistanceXZ(src,target,5))
        {
            print("两点间的距离小于5");
        }
    }
}
