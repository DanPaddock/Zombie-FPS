using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 25f;
    [SerializeField] float zoomOutSens = 2f;
    [SerializeField] float zoomInSens = 0.5f;

    bool isZoomed = false;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(isZoomed == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        isZoomed = false;
        fpsCamera.fieldOfView = zoomOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSens;
        fpsController.mouseLook.YSensitivity = zoomOutSens;
    }

    private void ZoomIn()
    {
        isZoomed = true;
        fpsCamera.fieldOfView = zoomInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSens;
        fpsController.mouseLook.YSensitivity = zoomInSens;
    }
}
