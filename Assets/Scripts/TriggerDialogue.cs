using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public AudioObject clipToPlay;
    public GameObject TheTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Trigger wake up " + clipToPlay);
            Vocals.instance.Say(clipToPlay);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger wake up " + clipToPlay);
            Vocals.instance.StopTheDialogue();
            TheTrigger.SetActive(false);
        }
    }
}
