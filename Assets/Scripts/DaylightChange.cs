using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightChange : MonoBehaviour
{
    [SerializeField]
    private GameObject TheSun;

    [SerializeField]
    private int AmountOfRotation = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeTimeOfDay() 
    {
        if (TheSun.transform.rotation.eulerAngles.x <= 45) 
        {
            TheSun.transform.Rotate(Vector3.right * AmountOfRotation);
        }
    }
}
