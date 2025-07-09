using UnityEngine;
using UnityEngine.Video;

public class saomiaoClick : MonoBehaviour
{
    private int scannedObjectCount = 0;
    private bool isScanningComplete = false;
    public GameObject[] Arrow;
    public GameObject[] Image;
    public ParticleSystem ParticleVFX;
    public ParticleSystem ParticleVFX1;
    public ParticleSystem ParticleVFX2;
    public ParticleSystem ParticleVFX3;
    public ParticleSystem ParticleVFX4;
    public AudioSource audio;
    public VideoPlayer player;
    public VideoClip clip;
    private bool Isopen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isScanningComplete && other.CompareTag("saomiaoClick"))
        {
            scannedObjectCount++;

            Debug.Log("Object scanned: " + scannedObjectCount);

            if (scannedObjectCount == 2 || scannedObjectCount == 4 || scannedObjectCount == 6)
            {
                switch (scannedObjectCount)
                {
                    case 2:
                        ExecuteMethodForTwo();
                        break;
                    case 4:
                        ExecuteMethodForFour();
                        break;
                    case 6:
                        ExecuteMethodForSix();
                        break;
                }
            }

            if (scannedObjectCount >= 6)
            {
                isScanningComplete = true;
            }

            other.gameObject.SetActive(false); // 隐藏当前 cube
        }
    }

    private void ExecuteMethodForTwo()
    {
        Debug.Log("Executing method for two scanned objects...");
        // 在这里编写当扫描到2个物体时需要执行的逻辑
        Image[0].SetActive(false);
        Arrow [0].SetActive(false );
        Arrow [1].SetActive(true );

    }

    private void ExecuteMethodForFour()
    {
        Debug.Log("Executing method for four scanned objects...");
        // 在这里编写当扫描到4个物体时需要执行的逻辑
        Image[1].SetActive(false);
        Arrow[0].SetActive(false);
        Arrow[1].SetActive(false);
        Arrow[2].SetActive(true);
    }

    private void ExecuteMethodForSix()
    {
        Debug.Log("Executing method for six scanned objects...");
        // 在这里编写当扫描到6个物体时需要执行的逻辑
        player.clip = clip;
        player.Play();
        Arrow[0].SetActive(false);
        Arrow[3].SetActive(true);
    }

    void Update()
    {
        // 如果视频播放完毕
        if (!player.isPlaying&& Isopen==false)
        {
            Debug.Log("Video has ended!");
            audio.Play();
            ParticleVFX.Play();
            ParticleVFX1.Play();
            ParticleVFX2.Play();
            ParticleVFX3.Play();
            ParticleVFX4.Play();
            
            Isopen = true;
        }
    }
}
