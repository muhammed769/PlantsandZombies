using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacksObjectWayTakeAway : MonoBehaviour
{
    public GameObject AttacksObjectPrefab;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //foreach (GameObject AttackPrefab in AttacksObjectPrefa)    *************************************************               BUG       ****************************************************************
        //{                                                          // OYUN ���N �OK KR�T�K A�IKLAMA :  SALDIRAN OBJELER� YOLA KOYAMIYORUZ ��NK�  �stteki AttacksObjectPrefab de�i�keni hata veriyor dolay�s�yla bu foreach d�ng�s� �al��m�yor !!!!!!!
        //    if (IsThereAttack(AttackPrefab))
        //    {
        //        AttackSettle(AttackPrefab);
        //    }

        //}
    }

    void AttackSettle(GameObject AttackObject)
    {
        GameObject RushObject = Instantiate(AttackObject) as GameObject ;
        RushObject.transform.parent = transform;
        RushObject.transform.position = transform.position;
    }

    bool IsThereAttack(GameObject AttackObject)
    {
        Attacks objectAttack = AttackObject.GetComponent<Attacks>();

        float birthwaitTime = objectAttack.SecondBirth;
        float birthWaitRate = 1 / birthwaitTime;

        
        float FinishRate = birthwaitTime * Time.deltaTime; // 0.16* 0.025 = 0.04

        if (Random.value < FinishRate)
        {
            return true;
        }

        else
        {
            return false;
        }
      
    }
}
