using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubtitleUIManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI subtitleText = default;

    public static SubtitleUIManager instance;

    public void Awake()
    {
        instance = this;
        ClearSubtile();
    }

    public void SetSubtile(string subtitle, float delay)
    {
        subtitleText.text = subtitle;
        StartCoroutine(ClearAfterSeconds(delay));
    }

    public void ClearSubtile() 
    {
        subtitleText.text = "";
    }

    private IEnumerator ClearAfterSeconds(float delay) 
    {
        yield return new WaitForSeconds(delay);
        ClearSubtile();
    }
}
