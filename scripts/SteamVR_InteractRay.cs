using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 物体射线交互
/// </summary>
public class SteamVR_InteractRay : MonoBehaviour
{
    public UnityAction OnRayEnter { get; set; }
    public UnityAction OnRayClick { get; set; }
    public UnityAction OnRayExit { get; set; }

    private void Start()
    {
        OnRayEnter = () => Debug.Log("射线进入 " + transform.name);
        OnRayClick = () => Debug.Log("射线点击 " + transform.name);
        OnRayExit = () => Debug.Log("射线离开 " + transform.name);
    }

    /// <summary>
    /// 射线进入
    /// </summary>
    public void RayEnter() { OnRayEnter?.Invoke(); }

    /// <summary>
    /// 射线点击
    /// </summary>
    public void RayClick() { OnRayClick?.Invoke(); }

    /// <summary>
    /// 射线离开
    /// </summary>
    public void RayExit() { OnRayExit?.Invoke(); }
}
