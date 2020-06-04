using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int ammoAmount;
    [SerializeField] AmmoType ammoType;
    [SerializeField] AudioClip[] pickupSounds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();
            FindObjectOfType<Ammo>().IncreaseCurrentAmmo(ammoType, ammoAmount);
            if(ammoType == AmmoType.Bullets)
            {
                AudioSource.PlayClipAtPoint(pickupSounds[0], transform.position);
            }
            else
            {
                AudioSource.PlayClipAtPoint(pickupSounds[1], transform.position);
            }
            Destroy(gameObject);
        }
    }
}
