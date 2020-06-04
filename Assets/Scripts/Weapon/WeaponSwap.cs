using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwap : MonoBehaviour
{
    [SerializeField] int currentWeaponID = 0;
    GameObject UI_Object;
    List<GameObject> UI_CircleChildren;

    void Start()
    {
        UI_Object = GameObject.Find("Gun Display Canvas");
        Debug.Log(UI_Object.transform);
        foreach (Transform child in UI_Object.transform)
        {
            Debug.Log(child);
            Debug.Log(child.GetChild(0).gameObject);
            UI_CircleChildren.Add(child.GetChild(0).gameObject);
            // UI_CircleChildren.Add(child.GetChild(0).gameObject);
        }
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
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (currentWeaponID >= transform.childCount - 1)
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

        foreach (Transform weapon in transform)
        {
            if (weaponIndex == currentWeaponID)
            {
                weapon.gameObject.SetActive(true);
                //SetGunUI(currentWeaponID);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

    private void SetGunUI(int WeaponID)
    {
        if (WeaponID == 0)
        {
            UI_CircleChildren[0].gameObject.GetComponent<Image>().enabled = true;
            UI_CircleChildren[1].gameObject.GetComponent<Image>().enabled = true;
            UI_CircleChildren[2].gameObject.GetComponent<Image>().enabled = true;
        }/*
        else if (WeaponID == 1)
        {
            UI_CircleChildren[0].SetActive(false);
            UI_CircleChildren[1].SetActive(true);
            UI_CircleChildren[2].SetActive(false);
        }
        else
        {
            UI_CircleChildren[0].SetActive(false);
            UI_CircleChildren[1].SetActive(false);
            UI_CircleChildren[2].SetActive(true);
        }*/

    }
}
