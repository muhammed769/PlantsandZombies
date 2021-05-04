using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefencesObjectsCreate : MonoBehaviour
{
    public Camera Wecamera;

    private GameObject DefenceObjectParent;


    private void Start()
    {
        DefenceObjectParent = GameObject.Find("Defences");
        if (!DefenceObjectParent)
        {
            DefenceObjectParent = new GameObject("Defences");// Hiearchy' ye fazladan bir obje att�g�nda(�rne�in Gnome) art�k hepsinin bullet'lar� Weapons Objesi alt�nda s�ralanacak !!!           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log(" Oyun y�zeyine t�kland�.");
        //Debug.Log(Input.mousePosition); // Maus pozisyonunun de�erini bast�rs�n.
        //Debug.Log(MousePozitionRealWorldTransfer());

        //Debug.Log(positionRoll(MousePozitionRealWorldTransfer()));

        Vector2 RealWorldPosition = MousePozitionRealWorldTransfer();
        Vector2 RealWorldPositionUpRoll = positionRoll(RealWorldPosition);
        //Debug.Log(RealWorldPositionUpRoll);

       GameObject newDefenceObject = Instantiate(PanelElementControl.chooseElement, RealWorldPositionUpRoll,Quaternion.identity) as GameObject;  // Art�k panel ' de se�ti�in bir objeyi istedi�in karede olu�turabilirsin.
        newDefenceObject.transform.parent = DefenceObjectParent.transform;

    }


    Vector2 positionRoll(Vector2 rollPosition)
    {
        float rollX = Mathf.CeilToInt(rollPosition.x);  // say�y�  yukar� yuvarlar �rne�in pozisyon 0.4 oldu�unda onu 1 'e yuvarlar.
        float rollY = Mathf.CeilToInt(rollPosition.y);
        return new Vector2(rollX, rollY);
    }



    Vector2 MousePozitionRealWorldTransfer()
    {
        float MouseX = Input.mousePosition.x;
        float MouseY = Input.mousePosition.y;
        float CameraDistance = 15f;

        Vector3 MousePosition = new Vector3(MouseX, MouseY, CameraDistance);
        Vector2 RealWorldPosition = Wecamera.ScreenToWorldPoint(MousePosition);


        return RealWorldPosition;
    }


}
