using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Button;

    [SerializeField]
    private float threshold = 0.1f;

    [SerializeField]
    private float deadzone = 0.025f;

    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _joint;

    public UnityEvent onPress;
    public UnityEvent onRelease;


    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
    }
    private void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1) 
        {
            Pressed();
        }
        if (_isPressed && GetValue() - threshold <= 0)
        {
            Released();
        }
    }

    private float GetValue()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;

        if (Math.Abs(value) < deadzone) 
        {
            value = 0;
        }

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed() 
    {
        _isPressed = true;
        onPress.Invoke();
        Debug.Log("Pressed");
    }
    private void Released() 
    {
        _isPressed = false;
        onRelease.Invoke();
        Debug.Log("Released");
    }
}
