using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 3;
    public PlayerMovement player;

    void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log(timer);
    }

    void TimerReset()
    {
        timer = 10;
        myAnimatorController.Play("Countdown", -1, normalizedTime = 0.0f);
    }
}
