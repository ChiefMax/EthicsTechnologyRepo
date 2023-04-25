using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScriptPhone : MonoBehaviour
{
    [SerializeField]
    private GameObject XRObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            XRObject.transform.position = new Vector3(-1.74f, 0.5f, -11.752f);
        }
    }
}
