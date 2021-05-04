using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
   // [Range(0f,1f)] // Walkspeed'i  oyun içerisinde  ayarlamamýzý saðlar. 
    private float nowSpeed;

    private GameObject currentTarget;

    private Animator ObjectAnimator;

    public float SecondBirth;
    //[Tooltip("Kaç saniyede bir doðacaðýný giriniz." )]// [Tooltip] deðiþkenin  Ne iþe yaradýðýný belirtir !  !  ! 

    
    void Start()
    {
        //Rigidbody2D ObjectRigidBody2D = gameObject.AddComponent<Rigidbody2D>(); // Attacks Scriptine sahip objelere kod üzerinden Rigidbody2D eklemiþ olduk.
        //ObjectRigidBody2D.isKinematic = true;
        ObjectAnimator = GetComponent<Animator>();
    }
  
    void Update()
    {
        transform.Translate(Vector3.left * nowSpeed * Time.deltaTime); // Transform.Translate objenin direk harekete geçmesini saðlar.Transform.Pozition 'lada yapabiliriz ancak bu yöntem daha kullanýþlýdýr.

        if (!currentTarget)
        {
            ObjectAnimator.SetBool("IsThereAttack", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Debug.Log(name + collision.name + "Trigger Gerçekleþti.");
    }
    public void NowSpeedAdjustto(float speed) // Parametre olarak speed deðerini animayon içerisinden vericez.
    {
        nowSpeed = speed;
    }

    public void  DamageGive(float Damagequantity) // Lizard ve Fox saldýrdýðýnda diðer objelere zarar vermesini saðlayan bir metot oluþturduk.
    {
        if (currentTarget)
        {
            Health healthValue = currentTarget.GetComponent<Health>();
            if (healthValue)
            {
                healthValue.SeeDamage(Damagequantity);
            }
        }
    }
    public void TargetAttack(GameObject Target)
    {
        currentTarget = Target;
    }

}
