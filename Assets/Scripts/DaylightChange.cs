using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightChange : MonoBehaviour
{
    [SerializeField]
    private GameObject TheSun;

    [SerializeField]
    private int AmountOfRotaion = 10;

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
        TheSun.transform.Rotate(Vector3.right * AmountOfRotaion);
    }
}
