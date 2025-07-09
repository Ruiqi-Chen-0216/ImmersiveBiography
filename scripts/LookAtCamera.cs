using UnityEngine;

/// <summary>
/// ������Ҫ����������ĳ��������ϣ�ʹ����ʼ�չ̶���ĳ�����������
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
        //����ʼ�����������
        var rotation = Quaternion.LookRotation(_mainCamera.transform.TransformVector(Vector3.forward),
            _mainCamera.transform.TransformVector(Vector3.up));
        rotation = new Quaternion(0, rotation.y, 0, rotation.w);
        gameObject.transform.rotation = rotation;
    }

}
