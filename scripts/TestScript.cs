using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
//����ű�Ҫ�ҵ�RightHand�ֱ���
public class TestScript : MonoBehaviour
{
    public SteamVR_Action_Boolean tigger;//�ճּ�
    Hand hand;//һ��Ҫȷ����Hand �ű�
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
            if (tigger.GetStateDown(hand.handType))//����
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