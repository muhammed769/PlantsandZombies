using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Attacks))] // Unity'de yanlýþlýkla Attacks Scriptini sildiginde sana bu Attack Scriptine sahip olman gerektigini SÖYLER !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
public class Fox : MonoBehaviour
{
    private Animator FoxAnimator;
    private Attacks AttackObject;

    void Start()
    {
        FoxAnimator = GetComponent<Animator>();
        AttackObject = GetComponent<Attacks>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject  FoxTriggerObject = collision.gameObject;

        if (!FoxTriggerObject.GetComponent<Defences>())
        {
            return; // Defences scriptine sahip deðilse metottan çýk.
        }
        else if (FoxTriggerObject.GetComponent<Stone>())
        {
            FoxAnimator.SetTrigger("IsThereJump");
        }
        else
        {
            FoxAnimator.SetBool("IsThereAttack", true);
            AttackObject.TargetAttack(FoxTriggerObject);
        }

    }


}
