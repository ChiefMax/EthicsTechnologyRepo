using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeavyFeelingAnim : MonoBehaviour
{
    [SerializeField]
    private GameObject theCanvas;

    [SerializeField]
    private InputActionReference TeleportButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
        theCanvas.GetComponent<Animator>().Play("WakeUpAnimation");
    }

    // Update is called once per frame
    void Update()
    {
        if (TeleportButton.action.IsPressed())
        {
            theCanvas.GetComponent<Animator>().Play("HeavyfeelingAnimation");
        }
    }
}
