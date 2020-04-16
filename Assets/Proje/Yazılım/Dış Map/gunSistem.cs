using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunSistem : MonoBehaviour
{
    private Text gunText;
    public float gunYazi;

    public GameObject saatObje;

    // Start is called before the first frame update
    void Start()
    {
        gunText = GetComponent<Text>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        gunYazi = saatObje.GetComponent<saatSistem>().Gun;


        gunText.text = "Day:" + gunYazi;
    }
}
