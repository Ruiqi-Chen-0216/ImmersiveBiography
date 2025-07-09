using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickboxOn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Obj;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            for (int i = 0; i < Obj.Length; i++)
            {
                Obj[i].SetActive(true);
            }
            
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
