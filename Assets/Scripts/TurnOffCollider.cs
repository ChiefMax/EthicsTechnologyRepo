using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TurnOffCollider : MonoBehaviour
{

    [SerializeField]
    private InputActionReference GripButton;

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
