using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HP = 100f;

    public void TakeDamage(float Damage)
    {
        HP -= Damage;
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
