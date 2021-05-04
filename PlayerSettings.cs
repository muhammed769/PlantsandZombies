using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSettings : MonoBehaviour 
{
    const string Home_Sound_Key = "Home_Sound";
    const string Level_Key = "Level_Open_";
    const string HardShip_Key = "HardShip";

    #region Home_Sound_Key Settings
    
    // Bir fonksiyon oluþturup ve bu fonksiyon Þu Home_Sound 'u  ayarlamamýzý saðlasýn  :   
    public static void HomeSoundSettings(float sound ) // Sesimiz 0 ile 1 arasýnda deðer alýcak .
    {
        /* ÇOK ÖNEMLÝ : 
           PlayerPrefs Bir  Unity'den gelen bir class'dýr.
           PlayerPrefs 'in Þöyle bir özelligi var : Oyuncunun gerekli iþlemlerini KALICI RAM 'DA TUTAR.YANÝ OYUNU KAPATTIGIMIZDA BÝLE  OYUNDA HANGÝ ÝÞLEMLERÝ YAPTIYSAK
           ONU KALICI RAM 'DE TUTAR VE OYUNU TEKRAR AÇTIGIMIZDA BÝZÝM ÖNÜMÜZE SUNAR.
            PlayerPrefs 'i gerektiginde kullanýn çünkü hafýzada yer tuttugu için  gereksiz kullaným durumunda Oyunu Optimizasyonu açýsýndan hiç saðlýklý
            bir durum DEÐÝLDÝR..*/
        

        if (sound>=0f && sound <=1f)
        {
            PlayerPrefs.SetFloat(Home_Sound_Key, sound);
        }
        else
        {
            Debug.LogError("[0,1] Aralýðý dýþýnda bir deger giremezsiniz.");
        }
        // NOT : Bir fonksiyona void yazdýgýn zaman bu þu demek Bu fonksiyon BU KOD SATIRLARI ARASINDA GERÇEKLEÞECEK DEMEKTÝR.
        // NOT : Bir fonksiyona static yazdýgýn zaman bu þu demek .Ben bu fonksiyonu BAÞKA BÝR CLASS iÇERÝSÝNDEDE KULLANABÝLÝRÝM.
    }

    public static float HomeSoundGet() // Þimdide Sound'un deðerini alabilecegimiz bir  fonksiyon yazdýk.
    {
        return PlayerPrefs.GetFloat(Home_Sound_Key);
    }
    #endregion

    #region Level_Key Settings
    // Bu anahtar sayesinde diyelim oyunda 3.seviyedeyiz 3 ün altýndaki seviyeleri oynayabiliriz bu anahtar kelime bu anlattýgým olayý gerçekleþtirmeye yarar.
    // Level_Open_0
    // Level_Open_1
    // Level_Open_2 ...
    public static void LevelLock(int Level) // Kullanýcý örnegin  4.Level'deyken 5'inci Level'i oynayamamasý için bu fonksiyonu oluþturduk :
    {
        if(Level<SceneManager.sceneCountInBuildSettings) // sceneCountInBuildSettings Buýild Setttings içindeki sahneleri söyler bize.Bizim 6 tane sahnemiz vardý.Yani  LEVEL'ÝMÝZ 6 sahneyi GEÇEMEZ.
        {
            PlayerPrefs.SetInt(Level_Key+Level.ToString(),1); // Burdaki 1 þunu ifade eder : HANGÝ SEVÝYEDE KALDIYSA ONU AÇ DEMEKTÝR.
        }
        else
        {
            Debug.LogError("Oyunda olmayan bir sahne açýlamaz.");
        }
    }

    public static bool LevelisitOpen(int Level) // Levelin kilidinin açýk olup olmadýgýnýn test eden bir fonksiyon oluþturduk :
    {
        int LevelValue = PlayerPrefs.GetInt(Level_Key + Level.ToString()); // Öncelikle hangi seviyede oldugumuzu bir alalým ilk önce 

        bool LevelisitOpen = (LevelValue == 1); // Yani Level 'im açýksa true dönecek demiþ oldum.

        if (Level < SceneManager.sceneCountInBuildSettings)
        {
            return LevelisitOpen;
        }
        else
        {
            Debug.LogError("Oyunda olmayan bir Level'in Lock'unu sorgulayamazsýn.");
            return false;
        }
    }

    #endregion

    #region HardShip_Key Settings 

    public static void hardshipSettings(float HardShip) // Zorlugu ayarlayacak bir fonksiyon oluþturduk.
    {
        if(HardShip>=1f && HardShip <= 5f)
        {
            PlayerPrefs.SetFloat(HardShip_Key, HardShip);
        }
        else
        {
            Debug.LogError("Zorluk seviyesi 1-5 arasýnda bir tamsayý olmalýdýr.");
        }
    }

    public static float GetHardShip() // Zorluk derecesini gösteren bir fonksiyon oluþturduk.
    {
        return PlayerPrefs.GetFloat(HardShip_Key);
    }
    #endregion

}
