using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelElementControl : MonoBehaviour
{

    public GameObject ElementPrefab;
    private PanelElementControl[] panelElements;
    public static GameObject chooseElement;

    void Start()
    {
      panelElements = GameObject.FindObjectsOfType<PanelElementControl>();  //GameObject dedi�imizde Hierarcy'deki b�t�n objelere bak�yor ve PanelElementControl Scriptine sahip objeleri panelElements ismini verdi�imiz dizininin i�ersinde tutuyor.
        foreach(PanelElementControl Element in panelElements)
        {
            Element.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() // Panel de se�mek istedi�im objeye t�klad���mda : 
    {
        //Debug.Log(name);

        chooseElement = ElementPrefab;
        GetComponent<SpriteRenderer>().color = Color.white;

        //foreach(PanelElementControl Element in panelElements)
        // {
        //     Element.GetComponent<SpriteRenderer>().color = Color.black;
        // }

        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
