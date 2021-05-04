using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public float NextSceneBurdenTime;
    private void Start()
    {
        if (SceneManager.GetActiveScene().name=="0.SceneBeforetheMenu")
        {
            Invoke("nextScene", NextSceneBurdenTime);
        }
       
    }


    public void nextScene() // Buttonlara týklayarak bir sonraki sahneye geçiþi saðlýcaz.
    {
        // SceneManager(SAhne yöneticisi) Class'ýný çaðýr.Bu Class'ý(Kütüphaneyi) EN ÜSTE EKLEMEN LAZIM.
        // SceneManager = Bize Sahneyi yüklemeyi saðlar.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Þuanki sahnemi bana getir ve bunun BuildIndex'nin bir sonraki numarasý olan sahneyi getir.
    }

    public void GameExit()
    {
       // Debug.Log("Oyundan çýkma iþlemi baþarýyla gerçekleþti.");
        Application.Quit(); // Oyundan çýkýþ iþlemlerini gerçekleþtiricez.Yani Butonumdan bu metotu çagýrdýgýmýzda oyundan çýkmýþ olucaz.
    }

    public void NameWithSceneCall(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void IndexWithSceneCall(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
