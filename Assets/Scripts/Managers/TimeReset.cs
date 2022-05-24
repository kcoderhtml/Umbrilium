using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeReset : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
        MenuManager.gameIsPaused = false;
    }
}
