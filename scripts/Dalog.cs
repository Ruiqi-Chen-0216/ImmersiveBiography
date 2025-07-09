using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dalog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] DalogUIs;
    public AudioClip[] Audios;
    public AudioSource AudioSource;
    public TextMeshProUGUI StartUI;
    public GameObject bookDesk;
    public GameObject BeginUI;
    private int count = 0;
    
    void Start()
    {
        AudioSource.clip = Audios[0];
        AudioSource.Play();
        bookDesk.SetActive(false);

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
    public void NextDalog()
    {
        count++;
        CloseDalog();
        Debug.Log(count + "B");
        if (count < DalogUIs.Length-1)
        {

           
            DalogUIs[count].gameObject.SetActive(true);

            AudioSource.clip = Audios[count];
            AudioSource.Play();

        }
        else
        {
            Debug.Log("Test");
           
            StartUI.text = "StartGame";
            //bookDesk.SetActive(true);
            CloseDalog();
            if (count > DalogUIs.Length-1)
            {
                
                BeginUI.SetActive(false);
                AudioSource.clip = Audios[Audios.Length-1];
                AudioSource.Play();
               

            }
        }



    }
    // Update is called once per frame
    void Update()
    {

    }
}
