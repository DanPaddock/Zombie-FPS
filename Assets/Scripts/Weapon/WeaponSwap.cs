using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    [SerializeField] int currentWeaponID = 0;

    void Start()
    {
        SetActiveWeapon();
    }

    void Update()
    {
        int previousWeapon = currentWeaponID;
        ProcessKeyInput();
        ProcessScrollWheel();

        if (previousWeapon != currentWeaponID)
        {
            SetActiveWeapon();
        }
    }

    private void ProcessScrollWheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if(currentWeaponID >= transform.childCount - 1)
            {
                currentWeaponID = 0;
            }
            else
            {
                currentWeaponID++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (currentWeaponID <= 0)
            {
                currentWeaponID = transform.childCount - 1;
            }
            else
            {
                currentWeaponID--;
            }
        }
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeaponID = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeaponID = 2;
        }
    }

    private void SetActiveWeapon()
    {
        int weaponIndex = 0;

        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currentWeaponID)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

}
