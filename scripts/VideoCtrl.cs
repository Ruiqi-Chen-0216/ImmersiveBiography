using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoCtrl : MonoBehaviour
{
    public VideoPlayer Vplayer;
    public VideoClip[] Clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeVideo1()
    {
        Vplayer.clip = Clip[0];
        Vplayer.Play();
    }
    public void ChangeVideo2()
    {
        Vplayer.clip = Clip[1];
        Vplayer.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
