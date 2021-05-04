using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSlowlyShow : MonoBehaviour
{

    public float slowlyShowTime;
    private Color currentColor = Color.black;

    void Start()
    {
        
    }

    
    void Update()
    {     
        if(Time.timeSinceLevelLoad<slowlyShowTime) // timeSinceLevelLoad  metodu : Oyunun yüklenme süresi
        {
            float alphaChange = Time.deltaTime / slowlyShowTime;
            currentColor.a -= alphaChange;  //  Burdaki a Alpha 'yý ÝFADE EDÝYOR.
            GetComponent<Image>().color = currentColor;           
        }
        else
        {
            gameObject.SetActive(false);
        }


    }
}
