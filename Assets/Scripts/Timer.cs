using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timeText;

    private int time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void UpdateTimer(int addTime)
    {
        time += addTime;
        timeText.text = "Time:" + time;
    }
}
