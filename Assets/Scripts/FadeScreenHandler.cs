using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FadeScreenHandler : MonoBehaviour
{
    [SerializeField]
    private bool OnStartFade = true;
    [SerializeField]
    public float FadeDuration = 2;
    [SerializeField]
    private Color fadeColor;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (OnStartFade)
            FadeIn();
    }

    // Update is called once per frame
    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        Fade(0, 1);
    }

    public void Fade(float AlphaIn, float AlphaOut)
    {
        StartCoroutine(FadeRoutine(AlphaIn, AlphaOut));
    }

    public IEnumerator FadeRoutine(float AlphaIn, float AlphaOut)
    {
        float timer = 0;
        while (timer <= FadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(AlphaIn, AlphaOut, timer / FadeDuration);
            rend.material.SetColor("_Color", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color _newColor = fadeColor;
        _newColor.a = AlphaOut;
        rend.material.SetColor("_Color", _newColor);
    }
}
