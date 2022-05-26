using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{

    public TextMeshProUGUI timeText;

    private bool timerActive;
    private int time;
    // Start is called before the first frame update
    void Start()
    {
        timerActive = true;
        time = 0;
        UpdateTimer(0);
        StartCoroutine(timerCount());
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

    IEnumerator timerCount()
    {
        while(timerActive)
        {
            yield return new WaitForSeconds(1);
            UpdateTimer(1);
            
        }
    }
}
