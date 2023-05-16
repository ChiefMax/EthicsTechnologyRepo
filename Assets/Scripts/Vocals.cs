using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Vocals : MonoBehaviour
{
    private AudioSource source;

    public static Vocals instance;

    private Queue audioClips;
    private Queue subtitleItems;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();
        StartCoroutine(WaitForDialogue(5f));
    }

    public void Say(AudioObject clip)
    {
        FillTheQueue(clip);

        if (source.isPlaying)
            source.Stop();
        
        for (int i = 0; i < clip.subtile.Length; i++) 
        {
            Debug.Log(clip.subtile.Length);
            source.PlayOneShot(clip.clip[i]);
            SubtitleUIManager.instance.SetSubtile(clip.subtile[i], clip.clip[i].length);
        }
    }

    public void FillTheQueue(AudioObject audioObject) 
    {
        foreach (var element in audioObject.clip) 
        {
            audioClips.Enqueue(element);
        }

        foreach (var element in audioObject.subtile) 
        {
            subtitleItems.Enqueue(element);
        }
    }

    private IEnumerator WaitForDialogue(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
    }
}
