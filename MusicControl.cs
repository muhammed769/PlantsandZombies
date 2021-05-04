using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    static MusicControl MusicPlayer;

    private void Awake() // Awake()  = HEMEN ÇALIÞTIRMAYA YARAR.
    {
        // Debug.Log("Avake Çalýþtý");
        if(MusicPlayer != null)
        {
            Destroy(gameObject); // Yani MusicPlayer(müzik oynatýcýsý) boþ degilse  yeni oluþan MusicPlayer'ý(müzik oynatýcýsýný) YOK EDÝCEK.
                                 // Çünkü ben Hierarcy'de Fazladan bir bir obje görmek istemem ve ayný zamanda Optimizasyon açýsýndanda bu son derece önemlidir.
        }
        else
        {
            MusicPlayer = this; // Yani MusicPlayer Boþsa þuan oluþturdugum objenin MusicPlayer'ý olmuþ olacak.

            // DontDestroyOnLoad() metodu þu demek : Yüklendiginde YOK ETME anlamýna gelir.
            GameObject.DontDestroyOnLoad(gameObject); // Yani artýk Muzik diger sahneye geçtigindede KAPANMAYACAK.
        }
    }
    public void Settingsound(float soundValue)
    {
        GetComponent<AudioSource>().volume = soundValue;
    }
    void Start()
    {
        // Debug.Log("Start metotu çalýþtý");
    }

   
    void Update()
    {
        
    }
}
