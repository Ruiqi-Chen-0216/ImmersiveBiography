using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIOpenCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    void Start()
    {
        
    }
    public void Openobj()
    {
        Invoke("openUI", 10);
    }
    private void openUI()
    {
        obj.SetActive(true );
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
