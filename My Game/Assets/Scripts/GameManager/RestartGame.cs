using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public float restartTimeDeath;
    public float restartTimeCredits;
    bool restartNow = false;
    float resetTime;

    public GameObject creditsBackground;
    public GameObject credits;

    // Update is called once per frame
    void Update()
    {
        if (restartNow == true && resetTime <= Time.time)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void Restart()
    {
        restartNow = true;
        resetTime = Time.time + restartTimeDeath;
    }

    public void PlayCredits()
    {
        creditsBackground.SetActive(true);
        credits.SetActive(true);
        restartNow = true;
        resetTime = Time.time + restartTimeCredits;
    }
}
