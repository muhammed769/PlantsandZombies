using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    static MusicControl MusicPlayer;

    private void Awake() // Awake()  = HEMEN �ALI�TIRMAYA YARAR.
    {
        // Debug.Log("Avake �al��t�");
        if(MusicPlayer != null)
        {
            Destroy(gameObject); // Yani MusicPlayer(m�zik oynat�c�s�) bo� degilse  yeni olu�an MusicPlayer'�(m�zik oynat�c�s�n�) YOK ED�CEK.
                                 // ��nk� ben Hierarcy'de Fazladan bir bir obje g�rmek istemem ve ayn� zamanda Optimizasyon a��s�ndanda bu son derece �nemlidir.
        }
        else
        {
            MusicPlayer = this; // Yani MusicPlayer Bo�sa �uan olu�turdugum objenin MusicPlayer'� olmu� olacak.

            // DontDestroyOnLoad() metodu �u demek : Y�klendiginde YOK ETME anlam�na gelir.
            GameObject.DontDestroyOnLoad(gameObject); // Yani art�k Muzik diger sahneye ge�tigindede KAPANMAYACAK.
        }
    }
    public void Settingsound(float soundValue)
    {
        GetComponent<AudioSource>().volume = soundValue;
    }
    void Start()
    {
        // Debug.Log("Start metotu �al��t�");
    }

   
    void Update()
    {
        
    }
}
