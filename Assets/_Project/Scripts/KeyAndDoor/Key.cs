using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public static bool hasKey;

    void Awake()
    {
      hasKey = false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
      hasKey = true;
      Destroy(gameObject);
    }
}
