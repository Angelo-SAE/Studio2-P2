using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFallRoofDie : MonoBehaviour
{

    [SerializeField] private float roofCheckRange, maxFallDistance;
    private float maxHeight;
    private Scene currentScene;

    void Start()
    {
      currentScene = SceneManager.GetActiveScene();
    }

    void Update()
    {
      RestartLevelButton();
      CheckRoofHit();
      CheckFall();
    }

    public void RestartLevel()
    {
      StaticTotalDeaths.deathCount++;
      SceneManager.LoadScene(currentScene.name);
    }

    private void RestartLevelButton()
    {
      if(Input.GetButtonDown("Reset"))
      {
        RestartLevel();
      }
    }

    private void CheckRoofHit()
    {
      if(Physics2D.Raycast(new Vector2(transform.position.x - 0.3f, transform.position.y), Vector3.up, roofCheckRange, 1 << 6) || Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), Vector3.up, roofCheckRange, 1 << 6))
      {
        RestartLevel();
      }
    }

    private void CheckFall()
    {
      if(!PlayerMovement.grounded)
      {
        if(transform.position.y > maxHeight)
        {
          maxHeight = transform.position.y;
        }
      } else {
        if(maxHeight - transform.position.y > maxFallDistance)
        {
          RestartLevel();
        }
        maxHeight = transform.position.y;
      }
    }

}
