using UnityEngine;

/// <summary>
/// 挂在需要看向摄像机的场景物体上，使物体始终固定于某轴面向摄像机
/// </summary>
public class LookAtCamera : MonoBehaviour
{
    public  GameObject _mainCamera;

    // Start is called before the first frame update
    private void Start()
    {
       
    }

    // Update is called once per frame
    private void Update()
    {
        //物体始终面向摄像机
        var rotation = Quaternion.LookRotation(_mainCamera.transform.TransformVector(Vector3.forward),
            _mainCamera.transform.TransformVector(Vector3.up));
        rotation = new Quaternion(0, rotation.y, 0, rotation.w);
        gameObject.transform.rotation = rotation;
    }

}
