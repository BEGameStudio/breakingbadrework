using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class saatSistem : MonoBehaviour
{
    
    private Text saatText;
    

    public float Timer,dakika,saniye,Gun;
    void Awake()
    {
     /*   gunYazi = GameObject.Find("gunYazi");
        saatYazi = GameObject.Find("saatYazi"); */

        saatText = GetComponent<Text>();
        
    }
    void Update()
    {
        

        

      dakika = Mathf.Floor(Timer / 60);       //SANİYEYİ DAKİKA GİBİ KULLAN GÜN DAHA HIZLI GEÇSİN
      saniye = Mathf.Floor(Timer % 60);
       Timer += Time.deltaTime *5;
        //  string second = LeadingZero(time.Second);
        if (Timer >= 0 && Timer <= 600)
        {
            saatText.text = "0" + dakika + ":" + saniye;


        }

        else
        {
            saatText.text = dakika + ":" + saniye;



        }

        if (saniye < 10)
        {
            saatText.text = "0" + dakika + ":" + "0" + saniye;




        }



        if (Timer >= 1440)
        {                       
            Timer = 0;
            Gun += 1;
            
        } 
    }
    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
