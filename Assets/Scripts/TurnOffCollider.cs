using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class TurnOffCollider : MonoBehaviour
{

    [SerializeField]
    private InputActionReference GripButton;

    [SerializeField]
    private InputActionReference pushUp;

    [SerializeField]
    private GameObject Helper;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GripButton.action.IsPressed())
        {
            Helper.SetActive(false);
        }
        
        if(!GripButton.action.IsPressed())  
        {
            Helper.SetActive(true);
        }
    }
}
