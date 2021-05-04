using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SeeDamage(float Damagequantity)
    {
        health -= Damagequantity;
        if (health <= 0)
        {
            ObjectDestroy();
        }
            
    }
    public void ObjectDestroy()
    {
        Destroy(gameObject);
    }


}
