using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private Animator LizardAnimator;
    private Attacks AttackObject;



    void Start()
    {
      LizardAnimator = GetComponent<Animator>();
        AttackObject = GetComponent<Attacks>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject  LizardTriggerObject = collision.gameObject;

        if (!LizardTriggerObject.GetComponent<Defences>())
        {
            return; // Defences scriptine sahip deðilse metottan çýk.
        }
        else
        {
            LizardAnimator.SetBool("IsThereAttack", true);
            AttackObject.TargetAttack(LizardTriggerObject);
        }
    }

}
