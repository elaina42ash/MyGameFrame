using UnityEngine;

public class MathUtil : MonoBehaviour
{
    #region 角度和弧度

    /// <summary>
    /// 角度转弧度的方法
    /// </summary>
    /// <param name="deg"> 角度值 </param>
    /// <returns> 弧度值 </returns>
    public static float Deg2Rad(float deg)
    {
        return deg * Mathf.Deg2Rad;
    }

    /// <summary>
    /// 弧度转角度的方法
    /// </summary>
    /// <param name="rad"> 弧度值 </param>
    /// <returns> 角度值 </returns>
    public static float Red2Deg(float rad)
    {
        return rad * Mathf.Rad2Deg;
    }

    #endregion

    #region 距离计算相关的

    /// <summary>
    /// 获取XZ平面上 两点的距离
    /// </summary>
    /// <param name="srcPos"></param>
    /// <param name="targetPos"></param>
    /// <returns></returns>
    public static float GetObjDistanceXZ(Vector3 srcPos, Vector3 targetPos)
    {
        srcPos.y = 0;
        targetPos.y = 0;
        return Vector3.Distance(srcPos, targetPos);
    }

    /// <summary>
    /// 判断两点之间距离 是否小于目标距离 XZ平面
    /// </summary>
    /// <param name="srcPos"> 点1 </param>
    /// <param name="targetPos"> 点2 </param>
    /// <param name="dis"> 距离 </param>
    /// <returns></returns>
    public static bool CheckObjDistanceXZ(Vector3 srcPos, Vector3 targetPos, float dis)
    {
        return GetObjDistanceXZ(srcPos, targetPos) <= dis;
    }

    /// <summary>
    /// 判断两点之间距离 是否小于目标距离 XY平面
    /// </summary>
    /// <param name="srcPos"> 点1 </param>
    /// <param name="targetPos"> 点2 </param>
    /// <param name="dis"> 距离 </param>
    /// <returns></returns>
    public static bool CheckObjDistanceXY(Vector3 srcPos, Vector3 targetPos, float dis)
    {
        return GetObjDistanceXY(srcPos, targetPos) <= dis;
    }

    /// <summary>
    /// 获取XY平面上 两点的距离
    /// </summary>
    /// <param name="srcPos"> 点1 </param>
    /// <param name="targetPos"> 点2 </param>
    /// <returns></returns>
    public static float GetObjDistanceXY(Vector3 srcPos, Vector3 targetPos)
    {
        srcPos.z = 0;
        targetPos.z = 0;
        return Vector3.Distance(srcPos, targetPos);
    }

    #endregion

    #region 位置判断相关

    /// <summary>
    /// 判断世界坐标系下的某一个点 是否在屏幕可见范围外
    /// </summary>
    /// <param name="pos"></param>
    /// <returns> 如果在可见范围外返回true,否则返回false </returns>
    public static bool IsWorldPosOutScreen(Vector3 pos)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(pos);
        // 判断是否在屏幕范围内
        if (screenPos.x >= 0 && screenPos.x <= Screen.width && screenPos.y >= 0 && screenPos.y <= Screen.height)
            return false;
        return true;
    }

    #endregion
}
