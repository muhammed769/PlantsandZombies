using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
   // [Range(0f,1f)] // Walkspeed'i  oyun i�erisinde  ayarlamam�z� sa�lar. 
    private float nowSpeed;

    private GameObject currentTarget;

    private Animator ObjectAnimator;

    public float SecondBirth;
    //[Tooltip("Ka� saniyede bir do�aca��n� giriniz." )]// [Tooltip] de�i�kenin  Ne i�e yarad���n� belirtir !  !  ! 

    
    void Start()
    {
        //Rigidbody2D ObjectRigidBody2D = gameObject.AddComponent<Rigidbody2D>(); // Attacks Scriptine sahip objelere kod �zerinden Rigidbody2D eklemi� olduk.
        //ObjectRigidBody2D.isKinematic = true;
        ObjectAnimator = GetComponent<Animator>();
    }
  
    void Update()
    {
        transform.Translate(Vector3.left * nowSpeed * Time.deltaTime); // Transform.Translate objenin direk harekete ge�mesini sa�lar.Transform.Pozition 'lada yapabiliriz ancak bu y�ntem daha kullan��l�d�r.

        if (!currentTarget)
        {
            ObjectAnimator.SetBool("IsThereAttack", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Debug.Log(name + collision.name + "Trigger Ger�ekle�ti.");
    }
    public void NowSpeedAdjustto(float speed) // Parametre olarak speed de�erini animayon i�erisinden vericez.
    {
        nowSpeed = speed;
    }

    public void  DamageGive(float Damagequantity) // Lizard ve Fox sald�rd���nda di�er objelere zarar vermesini sa�layan bir metot olu�turduk.
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
