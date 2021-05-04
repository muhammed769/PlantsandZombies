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
        soundSetting.value = PlayerSettings.HomeSoundGet(); //Art�k oyun kapat�l�p yeniden a��ld�g�nda ses seviyesini hangi seviyede b�rakt�ysak o seviyede a��lm�� olacak.
        HardShipSetting.value = PlayerSettings.GetHardShip();
        soundDirector = GameObject.FindObjectOfType<MusicControl>();
    }

    // Update is called once per frame
    void Update()
    {
        soundDirector.Settingsound(soundSetting.value); // MusicControl Scriptine gidip Settingsound metodunu olu�tur.
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
