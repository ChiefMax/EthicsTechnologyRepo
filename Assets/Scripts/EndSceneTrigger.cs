using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneTrigger : MonoBehaviour
{
    [SerializeField]
    private SceneTransition sceneTransition;
    private bool endTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endTrigger)
        {
            sceneTransition.GoToScene(2);
            endTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("EndGame");
            endTrigger = true;
        }
    }
}
