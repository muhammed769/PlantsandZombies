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
      panelElements = GameObject.FindObjectsOfType<PanelElementControl>();  //GameObject dediðimizde Hierarcy'deki bütün objelere bakýyor ve PanelElementControl Scriptine sahip objeleri panelElements ismini verdiðimiz dizininin içersinde tutuyor.
        foreach(PanelElementControl Element in panelElements)
        {
            Element.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() // Panel de seçmek istediðim objeye týkladýðýmda : 
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
