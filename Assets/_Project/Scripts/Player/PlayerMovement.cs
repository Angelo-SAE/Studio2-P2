using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float moveSpeed, jumpHeight, floorCheckRange, increaseGoo, decreaseGoo, noGoo;
    public static bool grounded;
    private float horizontal;
    private Vector3 startingPosition;
    public Timer timer;


    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();
      startingPosition = transform.position;
    }

    void Update()
    {
      Movement();
      CheckGrounded();
      Jump();
      GooCheck();
    }

    private void Movement()
    {
      horizontal = Input.GetAxis("Horizontal");

      rb2d.velocity = new Vector2(moveSpeed * horizontal, rb2d.velocity.y);
    }

    private void Jump()
    {
      if(Input.GetButtonDown("Jump") && grounded)
      {
        rb2d.AddForce(Vector3.up * jumpHeight * 100f, ForceMode2D.Impulse);
        timer.TimerReset();
      }
    }

    private void CheckGrounded()
    {
      if(Physics2D.Raycast(new Vector2(transform.position.x - 0.20f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 9) || Physics2D.Raycast(new Vector2(transform.position.x + 0.20f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 9))
      {
        GetComponent<PlayerMovement>().Reset();
        Debug.Log("RedDead");
        grounded = true;
      } else if(Physics2D.Raycast(new Vector2(transform.position.x - 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 6) || Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 6))
      {
        grounded = true;
      } else if(Physics2D.Raycast(new Vector2(transform.position.x - 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 7) || Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 7))
      {
        grounded = true;
      } else if(Physics2D.Raycast(new Vector2(transform.position.x - 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 8) || Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 8))
      {
        grounded = true;
      } else if(Physics2D.Raycast(new Vector2(transform.position.x - 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 10) || Physics2D.Raycast(new Vector2(transform.position.x + 0.3f, transform.position.y), -Vector3.up, floorCheckRange, 1 << 10))
      {
        grounded = true;
      } else {
        grounded = false;
      }
    }

    private void GooCheck()
    {
      if(Physics2D.Raycast(transform.position, -Vector3.up, floorCheckRange, 1 << 6))
      {
        jumpHeight = noGoo;
      } else if(Physics2D.Raycast(transform.position, -Vector3.up, floorCheckRange, 1 << 7))
      {
        jumpHeight = increaseGoo;
      } else if(Physics2D.Raycast(transform.position, -Vector3.up, floorCheckRange, 1 << 8))
      {
        jumpHeight = decreaseGoo;
      }
    }

    public void Reset()
    {
      transform.position = startingPosition;
      rb2d.velocity = Vector3.zero;
      grounded = true;
    }


}
