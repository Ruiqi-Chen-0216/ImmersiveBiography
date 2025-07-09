using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiIsOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objUI;
    void Start()
    {
        
    }
    public void OpenUI()
    {
        objUI.SetActive(true);
    }
    public void CloseUI()
    {
        objUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
