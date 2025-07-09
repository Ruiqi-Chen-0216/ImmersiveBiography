// create by �������ƿ�
// create time 2020.4.8
// ---------------------------���Ŵ���Ч��---------------------------

using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Zoom : PostEffectsBase
{
    // shader
    public Shader myShader;
    //���� 
    private Material mat = null;
    public Material material
    {
        get
        {
            // �����ɫ������������
            mat = CheckShaderAndCreateMaterial(myShader, mat);
            return mat;
        }
    }

    // �Ŵ�ǿ��
    [Range(-2.0f, 2.0f), Tooltip("�Ŵ�ǿ��")]
    public float zoomFactor = 0.4f;

    // �Ŵ󾵴�С
    [Range(0.0f, 0.2f), Tooltip("�Ŵ󾵴�С")]
    public float size = 0.15f;

    // ͹����Եǿ��
    [Range(0.0001f, 0.1f), Tooltip("͹����Եǿ��")]
    public float edgeFactor = 0.05f;

    // ��������λ��
    private Vector2 pos = new Vector4(0.5f, 0.5f);

    void Start()
    {
        //�ҵ���Ӧ��Shader�ļ�  
        myShader = Shader.Find("lcl/screenEffect/Zoom");
    }

    // ��Ⱦ��Ļ
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (material)
        {
            // ��������괫�ݸ�Shader
            material.SetVector("_Pos", pos);
            material.SetFloat("_ZoomFactor", zoomFactor);
            material.SetFloat("_EdgeFactor", edgeFactor);
            material.SetFloat("_Size", size);
            // ��Ⱦ
            Graphics.Blit(source, destination, material);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            //��mousePosת��Ϊ��0��1������
            pos = new Vector2(mousePos.x / Screen.width, mousePos.y / Screen.height);
        }
    }
}
