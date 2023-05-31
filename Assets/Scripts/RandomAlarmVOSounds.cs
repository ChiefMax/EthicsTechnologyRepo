using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAlarmVOSounds : MonoBehaviour
{
    [SerializeField]
    private AudioObject[] randomAudios;

    private int counter = 0;

    private bool isDoneWithAlarm = false;

    public void PlayRandomClip()
    {
        counter++;
        if (!isDoneWithAlarm && counter != randomAudios.Length)
        {
            Debug.Log(counter + " and the random audio " + randomAudios.Length);

            Vocals.instance.Say(randomAudios[counter]);
        }
        else 
        {
            isDoneWithAlarm = true;
            counter = randomAudios.Length;
        }

        
    }
}
