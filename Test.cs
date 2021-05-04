using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log ("Ses baþlangýç deðeri : "+PlayerSettings.HomeSoundGet()); 
        // PlayerSettings.HomeSoundSettings(0.2f); // Yani ses ayarý %20 seviyesinde.
        // Debug.Log("Ses ayarlandýktan sonraki deðeri : "+ PlayerSettings.HomeSoundGet());

        // Debug.Log(PlayerSettings.LevelisitOpen(2));
        // PlayerSettings.LevelLock(2); // Örnegin 2'inci Level'i açalým.
        // Debug.Log(PlayerSettings.LevelisitOpen(2));


        //Debug.Log(PlayerSettings.GetHardShip());
        PlayerSettings.hardshipSettings(3f);
        //Debug.Log(PlayerSettings.GetHardShip());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
