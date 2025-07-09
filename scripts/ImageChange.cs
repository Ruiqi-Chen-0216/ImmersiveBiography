using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChange : MonoBehaviour
{
    public ParticleSystem ParticleVFX;
    public ParticleSystem ParticleVFX1;
    public ParticleSystem ParticleVFX2;
    public AudioSource audio;
   
    public GameObject obj;
    public GameObject obj1;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="shuazi") 
        
        {


            obj.SetActive(true);
            obj1.SetActive(false);
            StartCoroutine( StartTimer());

        }
    }
    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(3f);
        // 在此处添加计时器结束后要执行的代码
        {
            Debug.Log("Yz001");
            ParticleVFX.Play();
            ParticleVFX1.Play();
            ParticleVFX2.Play();
            audio.Play();


        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
