using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timer = 3;
    public PlayerMovement player;
    public Animator animate;

    public void Update()
    {
        timer -= Time.deltaTime;
        Debug.Log(timer);
        string levelNumber = SceneManager.GetActiveScene().name;

        if (timer <= 0)
        {
            if (levelNumber == "Level 8")
            {
                SceneManager.LoadScene("Level 8");
            }

            if (levelNumber == "Level 10")
            {
                SceneManager.LoadScene("Level 10");
            }
        }
    }

    public void TimerReset()
    {
        timer = 3;
        Animator animate = gameObject.GetComponent<Animator>();
        animate.Rebind();
        animate.Update(0f);
    }
}
