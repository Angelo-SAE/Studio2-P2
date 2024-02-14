using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlaceholder : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (Input.GetKey("a") == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(-5, 0, 0);
        }

        if (Input.GetKey("d") == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(5, 0, 0);
        }
    }
}
