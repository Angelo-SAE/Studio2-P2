using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallRoofDie : MonoBehaviour
{

    [SerializeField] private float roofCheckRange, maxFallDistance;
    private float maxHeight;

    void Update()
    {
      CheckRoofHit();
      CheckFall();
    }

    private void CheckRoofHit()
    {
      if(Physics2D.Raycast(new Vector2(transform.position.x - 0.3f, transform.position.y), Vector3.up, roofCheckRange, 1 << 6) || Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), Vector3.up, roofCheckRange, 1 << 6))
      {
        GetComponent<PlayerMovement>().Reset();
        Debug.Log("dead");
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
          GetComponent<PlayerMovement>().Reset();
          Debug.Log("fallDead");
        }
        maxHeight = transform.position.y;
      }
    }
}
