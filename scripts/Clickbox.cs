using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickbox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Obj;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            Obj.SetActive(false);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        //if (other.tag == "Player")
        //{
        //    Obj.SetActive(true);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
