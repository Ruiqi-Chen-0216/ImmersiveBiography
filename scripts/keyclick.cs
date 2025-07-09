using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyclick : MonoBehaviour
{
    public Animator animator;
   
    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag=="Key") 
        {
            animator.SetBool("Isopen", true);
           
            Arrow.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
