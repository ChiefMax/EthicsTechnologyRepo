using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Vocals : MonoBehaviour
{
    private AudioSource source;

    public static Vocals instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
    }

    public void Say(AudioObject clip)
    {
        if (source.isPlaying)
            source.Stop();
        
        for (int i = 0; i < clip.subtile.Length; i++) 
        {
            StartCoroutine(WaitForDialogue(5f));
            //Debug.Log(element.Length + " and the other array " + clip.subtile.Length);
            source.PlayOneShot(clip.clip[i]);
            SubtitleUIManager.instance.SetSubtile(clip.subtile[i], clip.clip[i].length);

            
        }

        
        


    }

    private IEnumerator WaitForDialogue(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
    }
}
