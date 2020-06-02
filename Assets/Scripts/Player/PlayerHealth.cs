using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float HP = 100f;

    public void TakeDamage(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            GetComponent<DeathHandler>().handleDeath();
        }
    }
}
