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
    
    // Bir fonksiyon olu�turup ve bu fonksiyon �u Home_Sound 'u  ayarlamam�z� sa�las�n  :   
    public static void HomeSoundSettings(float sound ) // Sesimiz 0 ile 1 aras�nda de�er al�cak .
    {
        /* �OK �NEML� : 
           PlayerPrefs Bir  Unity'den gelen bir class'd�r.
           PlayerPrefs 'in ��yle bir �zelligi var : Oyuncunun gerekli i�lemlerini KALICI RAM 'DA TUTAR.YAN� OYUNU KAPATTIGIMIZDA B�LE  OYUNDA HANG� ��LEMLER� YAPTIYSAK
           ONU KALICI RAM 'DE TUTAR VE OYUNU TEKRAR A�TIGIMIZDA B�Z�M �N�M�ZE SUNAR.
            PlayerPrefs 'i gerektiginde kullan�n ��nk� haf�zada yer tuttugu i�in  gereksiz kullan�m durumunda Oyunu Optimizasyonu a��s�ndan hi� sa�l�kl�
            bir durum DE��LD�R..*/
        

        if (sound>=0f && sound <=1f)
        {
            PlayerPrefs.SetFloat(Home_Sound_Key, sound);
        }
        else
        {
            Debug.LogError("[0,1] Aral��� d���nda bir deger giremezsiniz.");
        }
        // NOT : Bir fonksiyona void yazd�g�n zaman bu �u demek Bu fonksiyon BU KOD SATIRLARI ARASINDA GER�EKLE�ECEK DEMEKT�R.
        // NOT : Bir fonksiyona static yazd�g�n zaman bu �u demek .Ben bu fonksiyonu BA�KA B�R CLASS i�ER�S�NDEDE KULLANAB�L�R�M.
    }

    public static float HomeSoundGet() // �imdide Sound'un de�erini alabilecegimiz bir  fonksiyon yazd�k.
    {
        return PlayerPrefs.GetFloat(Home_Sound_Key);
    }
    #endregion

    #region Level_Key Settings
    // Bu anahtar sayesinde diyelim oyunda 3.seviyedeyiz 3 �n alt�ndaki seviyeleri oynayabiliriz bu anahtar kelime bu anlatt�g�m olay� ger�ekle�tirmeye yarar.
    // Level_Open_0
    // Level_Open_1
    // Level_Open_2 ...
    public static void LevelLock(int Level) // Kullan�c� �rnegin  4.Level'deyken 5'inci Level'i oynayamamas� i�in bu fonksiyonu olu�turduk :
    {
        if(Level<SceneManager.sceneCountInBuildSettings) // sceneCountInBuildSettings Bu�ild Setttings i�indeki sahneleri s�yler bize.Bizim 6 tane sahnemiz vard�.Yani  LEVEL'�M�Z 6 sahneyi GE�EMEZ.
        {
            PlayerPrefs.SetInt(Level_Key+Level.ToString(),1); // Burdaki 1 �unu ifade eder : HANG� SEV�YEDE KALDIYSA ONU A� DEMEKT�R.
        }
        else
        {
            Debug.LogError("Oyunda olmayan bir sahne a��lamaz.");
        }
    }

    public static bool LevelisitOpen(int Level) // Levelin kilidinin a��k olup olmad�g�n�n test eden bir fonksiyon olu�turduk :
    {
        int LevelValue = PlayerPrefs.GetInt(Level_Key + Level.ToString()); // �ncelikle hangi seviyede oldugumuzu bir alal�m ilk �nce 

        bool LevelisitOpen = (LevelValue == 1); // Yani Level 'im a��ksa true d�necek demi� oldum.

        if (Level < SceneManager.sceneCountInBuildSettings)
        {
            return LevelisitOpen;
        }
        else
        {
            Debug.LogError("Oyunda olmayan bir Level'in Lock'unu sorgulayamazs�n.");
            return false;
        }
    }

    #endregion

    #region HardShip_Key Settings 

    public static void hardshipSettings(float HardShip) // Zorlugu ayarlayacak bir fonksiyon olu�turduk.
    {
        if(HardShip>=1f && HardShip <= 5f)
        {
            PlayerPrefs.SetFloat(HardShip_Key, HardShip);
        }
        else
        {
            Debug.LogError("Zorluk seviyesi 1-5 aras�nda bir tamsay� olmal�d�r.");
        }
    }

    public static float GetHardShip() // Zorluk derecesini g�steren bir fonksiyon olu�turduk.
    {
        return PlayerPrefs.GetFloat(HardShip_Key);
    }
    #endregion

}
