using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
//这个脚本要挂到RightHand手柄上
public class TestScript : MonoBehaviour
{
    public SteamVR_Action_Boolean tigger;//握持键
    Hand hand;//一定要确保有Hand 脚本
    // Start is called before the first frame update
    public GameObject obj;
    public bool Isopen=false;
    void Start()
    {
        hand = GetComponent<Hand>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hand)
        {
            if (tigger.GetStateDown(hand.handType))//按下
            {
               
                if (Isopen == false)
                {
                    obj.SetActive(true);
                    Isopen = true;
                }
                else if (Isopen == true)
                {
                    obj.SetActive(false);
                    Isopen = false;
                }
                
                
            }
        }

    }
}