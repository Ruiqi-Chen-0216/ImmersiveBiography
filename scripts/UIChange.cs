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
        // �ڴ˴���Ӽ�ʱ��������Ҫִ�еĴ���
        objJf.SetActive(true);
        objhuajuan.SetActive(false);

    }
    private void executeTrigger(string triggerName)
    {
        //���������������岻��Ϊ��
        if (objhuajuan != null)
        {
            //��ȡ��������Ķ������
            var animator = objhuajuan.GetComponent<Animator>();
            //���������Ϊ��
            if (animator != null)
            {
                //������������ó���������
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
