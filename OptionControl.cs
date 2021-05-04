using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionControl : MonoBehaviour
{
    public Slider soundSetting;
    public Slider HardShipSetting;
    private MusicControl soundDirector;
    public SceneControl sceneDirector;

    // Start is called before the first frame update
    void Start()
    {
        soundSetting.value = PlayerSettings.HomeSoundGet(); //Artýk oyun kapatýlýp yeniden açýldýgýnda ses seviyesini hangi seviyede býraktýysak o seviyede açýlmýþ olacak.
        HardShipSetting.value = PlayerSettings.GetHardShip();
        soundDirector = GameObject.FindObjectOfType<MusicControl>();
    }

    // Update is called once per frame
    void Update()
    {
        soundDirector.Settingsound(soundSetting.value); // MusicControl Scriptine gidip Settingsound metodunu oluþtur.
    }

    public  void SoundSaveandExit()
    {
        PlayerSettings.HomeSoundSettings(soundSetting.value);
        PlayerSettings.hardshipSettings(HardShipSetting.value);
        sceneDirector.NameWithSceneCall("1.Menu");
    }

    public void StartSettingsApply()
    {
        soundSetting.value = 0.5f;
        HardShipSetting.value= 2f;
    }

}
