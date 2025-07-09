using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class UIChange : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject UI;
    public GameObject objhuajuan;
    public GameObject objJf;
    void Start()
    {
        
    }
    public void OpenUI()
    {
        UI.SetActive(true);
        UI.GetComponent<AudioSource>().Play();
    }
    public void CloseUI() 
    
    {
        objJf.SetActive(false);
        objhuajuan.SetActive(true);
        
        
        executeTrigger("Open");



    }
    public void Changehuajuan()
    {
        executeTrigger("Close");
        StartCoroutine(StartTimer());
    }
    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(3f);
        // 在此处添加计时器结束后要执行的代码
        objJf.SetActive(true);
        objhuajuan.SetActive(false);

    }
    private void executeTrigger(string triggerName)
    {
        //传进来的箱子物体不能为空
        if (objhuajuan != null)
        {
            //获取箱子物体的动画组件
            var animator = objhuajuan.GetComponent<Animator>();
            //动画组件不为空
            if (animator != null)
            {
                //给动画组件设置出发的名字
                animator.SetTrigger(triggerName);
                Debug.Log("Yz");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
