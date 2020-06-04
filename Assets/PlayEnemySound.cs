using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEnemySound : MonoBehaviour
{
    [SerializeField] AudioClip[] idleClips;
    [SerializeField] AudioClip[] attackClips;
    [SerializeField] AudioClip[] walkingClips;
    [SerializeField] AudioClip[] deathClips;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void PlayIdleSound()
    {
        int chance = Random.Range(0, 10);
        if(chance < 3) AudioSource.PlayClipAtPoint(idleClips[Random.Range(0, idleClips.Length)], transform.position);

    }

    private void PlayAttackSound()
    {
         AudioSource.PlayClipAtPoint(attackClips[Random.Range(0, attackClips.Length)], transform.position);
    }

    private void PlayWalkingSound()
    {
        int chance = Random.Range(0, 10);
        if (chance < 3) AudioSource.PlayClipAtPoint(walkingClips[Random.Range(0, walkingClips.Length)], transform.position);
    }

    private void PlayDeathSound()
    {
         AudioSource.PlayClipAtPoint(deathClips[Random.Range(0, deathClips.Length)], transform.position);
    }
}
