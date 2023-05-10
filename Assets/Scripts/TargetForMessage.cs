using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class TargetForMessage : MonoBehaviour
{
    [SerializeField]
    private Transform targetGraphic;
    [SerializeField]
    private Transform linkedHandPosition;
    [SerializeField]
    private GameObject XRRayinteractor;
    [SerializeField]
    private InputActionReference TriggerButton;
    [SerializeField]
    private GameObject[] messages;

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(linkedHandPosition.position, linkedHandPosition.forward, out hit, 10f) && hit.transform.tag == "Messages")
        {
            targetGraphic.position = hit.point + hit.normal * 0.001f;

            targetGraphic.rotation = Quaternion.LookRotation(hit.normal);

            if (!targetGraphic.gameObject.activeInHierarchy)
            {
                targetGraphic.gameObject.SetActive(true);
                XRRayinteractor.gameObject.SetActive(true);
            }

            if (TriggerButton.action.IsPressed())
            {
                //messages[hit.transform.].SetActive(false);
                Destroy(hit.transform.gameObject);
            }
        }
        else 
        {
            if (targetGraphic.gameObject.activeInHierarchy)
            {
                targetGraphic.gameObject.SetActive(false);
                XRRayinteractor.gameObject.SetActive(false);
            }
        }
    }
}
