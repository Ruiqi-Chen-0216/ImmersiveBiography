using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottleclick : MonoBehaviour
{
    public GameObject bottle1Obj;
    public GameObject bottle2Obj;
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bottle1")
        {
            bottle1Obj.SetActive(true);
        }
        if (other.tag == "bottle2")
        {
            bottle2Obj.SetActive(true);
        }

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
