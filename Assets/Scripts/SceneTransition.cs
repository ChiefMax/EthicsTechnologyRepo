using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField]
    private FadeScreenHandler fadeScreen;

    [SerializeField]
    private int SelectScene;

    private bool isTransition = false;


    public void Update()
    {
        if (isTransition)
        {
            Debug.Log("Transition to scene");
            GoToScene(SelectScene);
            isTransition = false;
        }
    }

    public void GoToScene(int SceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(SceneIndex));
    }

    IEnumerator GoToSceneRoutine(int SceneIndex)
    {
        
        fadeScreen.FadeOut();
        Debug.Log(fadeScreen);
        yield return new WaitForSeconds(fadeScreen.FadeDuration);

        SceneManager.LoadScene(SceneIndex);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Phone")
        {
            Debug.Log("Phone Collided");
            isTransition = true;
        }
    }
}
