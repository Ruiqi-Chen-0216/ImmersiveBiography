using UnityEngine;
using Valve.VR.Extras;

/// <summary>
/// 物体射线交互管理
/// </summary>
public class SteamVR_RayHandler : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;      //激光组件

    private void Awake()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
    }

    private void Start()
    {
        laserPointer.PointerIn += LaserPointer_PointerIn;
        laserPointer.PointerClick += LaserPointer_PointerClick;
        laserPointer.PointerOut += LaserPointer_PointerOut;
    }

    private void LaserPointer_PointerIn(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<SteamVR_InteractRay>() != null)
        {
            e.target.GetComponent<SteamVR_InteractRay>().RayEnter();
        }
    }

    private void LaserPointer_PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<SteamVR_InteractRay>() != null)
        {
            e.target.GetComponent<SteamVR_InteractRay>().RayClick();
            Debug.Log("AAA");
        }
    }

    private void LaserPointer_PointerOut(object sender, PointerEventArgs e)
    {
        if (e.target.GetComponent<SteamVR_InteractRay>() != null)
        {
            e.target.GetComponent<SteamVR_InteractRay>().RayExit();
        }
    }
}
