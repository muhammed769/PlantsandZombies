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
        if(Time.timeSinceLevelLoad<slowlyShowTime) // timeSinceLevelLoad  metodu : Oyunun y�klenme s�resi
        {
            float alphaChange = Time.deltaTime / slowlyShowTime;
            currentColor.a -= alphaChange;  //  Burdaki a Alpha 'y� �FADE ED�YOR.
            GetComponent<Image>().color = currentColor;           
        }
        else
        {
            gameObject.SetActive(false);
        }


    }
}
