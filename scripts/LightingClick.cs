using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject  obj;
    public float delayTime = 1f;
    private bool Off=true;
    void Start()
    {
        // 获取当前对象上的指定类型的组件
        obj.GetComponent<Outline>();

    }
    Color RandomColor()
    {
        //随机颜色的RGB值。即刻得到一个随机的颜色
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color color = new Color(r, g, b);
        return color;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player") 
        { obj.GetComponent<Outline>().enabled = true;
        
        Off = true; 
        }

       
    }
   
    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(delayTime);
        // 在此处添加计时器结束后要执行的代码
        Color Sgb = RandomColor();
        obj.GetComponent<Outline>().OutlineColor = Sgb;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") 
        { obj.GetComponent<Outline>().enabled = false;
            Off = false ;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Off==true) 
        {
            StartCoroutine(StartTimer()); 
        
        
        }
        
    }
}
