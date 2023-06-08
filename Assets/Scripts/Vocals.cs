using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Animations;

public class Vocals : MonoBehaviour
{
    private AudioSource source;

    public static Vocals instance;

    private Queue<AudioClip> audioClips;
    private Queue<string> subtitleItems;

    private int counter;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        source = gameObject.AddComponent<AudioSource>();

        if (source.isPlaying)
            source.Stop();
    }

    public void Say(AudioObject clip)
    {
        FillTheQueue(clip);

        if (source.isPlaying)
            source.Stop();

        counter = clip.subtile.Count();

        StartCoroutine(SayCoroutine());
    }

    public IEnumerator SayCoroutine()
    {
        while(audioClips.Count > 0)
        {
            Debug.Log(audioClips.Count);
            AudioClip currentClip = audioClips.Dequeue();
            source.PlayOneShot(currentClip);
            SubtitleUIManager.instance.SetSubtile(subtitleItems.Dequeue());
            counter--;
            yield return new WaitForSeconds(currentClip.length);
        }

        if (counter == 0) 
        {
            SubtitleUIManager.instance.ClearSubtile();
        }
    }

    public void FillTheQueue(AudioObject audioObject) 
    {
        audioClips = new();
        subtitleItems = new();
        foreach (var element in audioObject.clip)
        {
            audioClips.Enqueue(element);
        }

        foreach (var element in audioObject.subtile)
        {
            subtitleItems.Enqueue(element);
        }
    }

    public void StopTheDialogue() 
    {
        if (source.isPlaying)
            source.Stop();
    }

    private IEnumerator WaitForDialogue(float WaitTime)
    {
        yield return new WaitForSeconds(WaitTime);
    }
}
