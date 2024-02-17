using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Player;
    public GameObject PortalStart;
    public Transform PortalEnd;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
            Player.transform.position = PortalEnd.transform.position;
        }
    } 
}
