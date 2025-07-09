using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// �������߽���
/// </summary>
public class SteamVR_InteractRay : MonoBehaviour
{
    public UnityAction OnRayEnter { get; set; }
    public UnityAction OnRayClick { get; set; }
    public UnityAction OnRayExit { get; set; }

    private void Start()
    {
        OnRayEnter = () => Debug.Log("���߽��� " + transform.name);
        OnRayClick = () => Debug.Log("���ߵ�� " + transform.name);
        OnRayExit = () => Debug.Log("�����뿪 " + transform.name);
    }

    /// <summary>
    /// ���߽���
    /// </summary>
    public void RayEnter() { OnRayEnter?.Invoke(); }

    /// <summary>
    /// ���ߵ��
    /// </summary>
    public void RayClick() { OnRayClick?.Invoke(); }

    /// <summary>
    /// �����뿪
    /// </summary>
    public void RayExit() { OnRayExit?.Invoke(); }
}
