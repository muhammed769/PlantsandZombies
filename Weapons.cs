using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public float speed, givedamage;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attacks attackobject = collision.gameObject.GetComponent<Attacks>();
        Health AttackObjectHealth = collision.gameObject.GetComponent<Health>();

        if (attackobject && AttackObjectHealth)
        {
            AttackObjectHealth.SeeDamage(givedamage);
            Destroy(gameObject);
        }
    }
}
