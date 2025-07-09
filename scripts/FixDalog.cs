using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FixDalog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] DalogUIs;
    public AudioClip[] Audios;
    public AudioSource AudioSource;
    public Text StartUI;

   
    private int count = 0;
    void Start()
    {



    }
    private void CloseDalog()
    {
        AudioSource.Pause();
        Debug.Log(count + "ÒÑÇå¿Õ");
        for (int i = 0; i < DalogUIs.Length - 1; i++)
        {
            DalogUIs[i].gameObject.SetActive(false);
        }

    }
    public void OpenUI()
    {
       
        AudioSource.clip = Audios[0];
        AudioSource.Play();
        count = 0;
        StartUI.text = "Next";
        DalogUIs[count].gameObject.SetActive(true);
    }
    public void NextDalog()
    {
        count++;
        CloseDalog();
        Debug.Log(count + "B");
        if (count < DalogUIs.Length - 1)
        {


            DalogUIs[count].gameObject.SetActive(true);

            AudioSource.clip = Audios[count];
            AudioSource.Play();

        }
        else
        {
            Debug.Log("Test");

            StartUI.text = "½áÊø";
            CloseDalog();
            if (count > DalogUIs.Length - 1)
            {

                
            }
        }



    }
    // Update is called once per frame
    void Update()
    {

    }
}
