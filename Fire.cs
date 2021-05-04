using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet,BulletExitPoint;
    private GameObject bulletParent;
    private Animator ObjectAnimator;
    private AttacksObjectWayTakeAway WayAttack;

    // Animator'daki Motion 'lara Event ekleriz burdan ula�abilicez.


    private void Start()
    {
        ObjectAnimator = GetComponent<Animator>();
        bulletParent = GameObject.Find("Weapons");
        if (!bulletParent)
        {
            bulletParent = new GameObject("Weapons");// Hiearchy' ye fazladan bir obje att�g�nda(�rne�in Gnome) art�k hepsinin bullet'lar� Weapons Objesi alt�nda s�ralanacak !!!           
        }
        AttackObjectWaySet();
    }


    private void Update()
    {
        if (IsThereAttacksObjectWay())
        {
            ObjectAnimator.SetBool("IsThereAttack", true);
        }
        else
        {
            ObjectAnimator.SetBool("IsThereAttack", false);
        }
    }
    private void fire()
    {
        GameObject newbullet = Instantiate(bullet) as GameObject;
        newbullet.transform.position = BulletExitPoint.transform.position;
        newbullet.transform.parent = bulletParent.transform;
    }

    void AttackObjectWaySet() 
    {
        AttacksObjectWayTakeAway[] GameAttackObjectsWays = GameObject.FindObjectsOfType<AttacksObjectWayTakeAway>();
        foreach (AttacksObjectWayTakeAway attackObjectExitLocation in GameAttackObjectsWays)
        {
            if(attackObjectExitLocation.transform.position.y == transform.position.y)
            {
                WayAttack = attackObjectExitLocation;
                return; // foreach 'in bitmesini sa�lad�k.
            }
        }
    }

    bool IsThereAttacksObjectWay()
    {
        if (WayAttack.transform.childCount<=0)
        {
            return false;
        }

        foreach (Transform RushObject in WayAttack.transform)
        {
            if (RushObject.transform.position.x > transform.position.x)
            {
                return true;
            }
        }
        return true;





    }

}
