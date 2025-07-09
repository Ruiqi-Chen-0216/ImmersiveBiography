using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class huabiClick : MonoBehaviour
{
    public Image image; // 要操作的图片对象
    public GameObject VFx;
    public GameObject obj;
    public float fadeDuration = 5f; // 渐变持续时间

    private Color initialColor; // 初始颜色

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
        initialColor = image.color; // 获取图片初始颜色
        initialColor.a = 0f; // 将初始颜色的alpha值设为0
        image.color = initialColor; // 设置图片初始颜色

        // 开始渐变
        
    }

  
    private  IEnumerator FadeInImage()
    {
        float timer = 0f;
        while (timer < fadeDuration)
        {
            // 计算当前透明度
            float alpha = Mathf.Lerp(0f, 125f / 255f, timer / fadeDuration);

            // 更新图片透明度
            Color newColor = image.color;
            newColor.a = alpha;
            image.color = newColor;

            timer += Time.deltaTime;
            yield return null;
        }

        // 设置最终透明度
        Color finalColor = initialColor;
        finalColor.a = 125f / 255f;
        image.color = finalColor;
        VFx.SetActive(false);
        obj.SetActive(true);
    }
}
