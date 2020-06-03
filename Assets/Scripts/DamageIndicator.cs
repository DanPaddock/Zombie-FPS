using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIndicator : MonoBehaviour
{

    [SerializeField] Canvas impactCanvas;
    [SerializeField] float impactTime = 0.3f;

    void Start()
    {
        impactCanvas.enabled = false;   
    }

    public void IndicateDamage()
    {
        StartCoroutine(ShowBlood());
    }

    IEnumerator ShowBlood()
    {
        impactCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        impactCanvas.enabled = false;
    }
}
