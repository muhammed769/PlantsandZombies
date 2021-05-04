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


    public void nextScene() // Buttonlara t�klayarak bir sonraki sahneye ge�i�i sa�l�caz.
    {
        // SceneManager(SAhne y�neticisi) Class'�n� �a��r.Bu Class'�(K�t�phaneyi) EN �STE EKLEMEN LAZIM.
        // SceneManager = Bize Sahneyi y�klemeyi sa�lar.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // �uanki sahnemi bana getir ve bunun BuildIndex'nin bir sonraki numaras� olan sahneyi getir.
    }

    public void GameExit()
    {
       // Debug.Log("Oyundan ��kma i�lemi ba�ar�yla ger�ekle�ti.");
        Application.Quit(); // Oyundan ��k�� i�lemlerini ger�ekle�tiricez.Yani Butonumdan bu metotu �ag�rd�g�m�zda oyundan ��km�� olucaz.
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
