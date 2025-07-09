using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.EventSystems;

public class SteamVR_UIPointer : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;

    [Header("显示激光"), SerializeField]
    private bool enablePointer = true;

    private void Awake()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
    }

    private void Start()
    {
        if (!enablePointer)
        {
            laserPointer.enabled = false;
            return;
        }
        else
        {
            laserPointer.PointerIn += LaserPointer_PointerIn;
            laserPointer.PointerClick += LaserPointer_PointerClick;
            laserPointer.PointerOut += LaserPointer_PointerOut;
        }
    }

    private void LaserPointer_PointerIn(object sender, PointerEventArgs e)
    {
        IPointerEnterHandler pointerEnterHandler = e.target.GetComponent<IPointerEnterHandler>();
        if (pointerEnterHandler != null)
        {
            pointerEnterHandler.OnPointerEnter(new PointerEventData(EventSystem.current));

            Debug.Log("射线进入");
        }
    }

    private void LaserPointer_PointerClick(object sender, PointerEventArgs e)
    {
        IPointerClickHandler pointerClickHandler = e.target.GetComponent<IPointerClickHandler>();
        if (pointerClickHandler != null)
        {
            pointerClickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
            Debug.Log("射线点击");
        }
    }

    private void LaserPointer_PointerOut(object sender, PointerEventArgs e)
    {
        IPointerExitHandler pointerExitHandler = e.target.GetComponent<IPointerExitHandler>();
        if (pointerExitHandler != null)
        {
            pointerExitHandler.OnPointerExit(new PointerEventData(EventSystem.current));
            Debug.Log("射线退出");
        }
    }
}
