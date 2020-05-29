using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera playerCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage = 30f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootWeapon();
        }
    }

    private void ShootWeapon()
    {
        RaycastHit hit;
        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, range))
        {
            Debug.Log("Hit: " + hit.transform.name);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }
    }
}
