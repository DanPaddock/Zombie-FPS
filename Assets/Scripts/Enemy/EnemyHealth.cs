using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HP = 100f;

    bool isDead = false;

    public bool GetIsDead()
    {
        return isDead;
    }

    public void TakeDamage(float Damage)
    {
        BroadcastMessage("onDamageTaken");
        HP -= Damage;
        if(HP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("Death");
    }
}
