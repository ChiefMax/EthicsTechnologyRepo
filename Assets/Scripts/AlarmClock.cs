using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlarmClock : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI alarmText;

    Queue<string> randomTimes = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {
        randomTimes.Enqueue("07:30");
        randomTimes.Enqueue("07:56");
        randomTimes.Enqueue("08:27");
        randomTimes.Enqueue("08:38");
        randomTimes.Enqueue("09:00");
    }

    public void ChangeTheTime()
    {
        alarmText.text = randomTimes.Dequeue();
    }
}
