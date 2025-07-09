using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class huabiClick : MonoBehaviour
{
    public Image image; // Ҫ������ͼƬ����
    public GameObject VFx;
    public GameObject obj;
    public float fadeDuration = 5f; // �������ʱ��

    private Color initialColor; // ��ʼ��ɫ

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Yz");
        if (other.tag == "shuazi") 
        
        {
            StartCoroutine(FadeInImage());
        }

        
    }
    void Start()
    {
        initialColor = image.color; // ��ȡͼƬ��ʼ��ɫ
        initialColor.a = 0f; // ����ʼ��ɫ��alphaֵ��Ϊ0
        image.color = initialColor; // ����ͼƬ��ʼ��ɫ

        // ��ʼ����
        
    }

  
    private  IEnumerator FadeInImage()
    {
        float timer = 0f;
        while (timer < fadeDuration)
        {
            // ���㵱ǰ͸����
            float alpha = Mathf.Lerp(0f, 125f / 255f, timer / fadeDuration);

            // ����ͼƬ͸����
            Color newColor = image.color;
            newColor.a = alpha;
            image.color = newColor;

            timer += Time.deltaTime;
            yield return null;
        }

        // ��������͸����
        Color finalColor = initialColor;
        finalColor.a = 125f / 255f;
        image.color = finalColor;
        VFx.SetActive(false);
        obj.SetActive(true);
    }
}
