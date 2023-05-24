using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeavyFeelingAnim : MonoBehaviour
{
    [SerializeField]
    private AnimationClip heavyfeeling;

    private Animation anim;

    [SerializeField]
    private InputActionReference TeleportButton;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TeleportButton.action.IsPressed())
        {
            anim.clip = heavyfeeling;
            anim.Play();
        }
    }
}
