using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float speed;
    public Vector2 speed_vec;

    Animator anim;

    private void Start()
    {
        Camera.main.transform.parent = transform;
        Camera.main.transform.localPosition = new Vector3(0, 0, -10);
        
        anim = GetComponent<Animator>();

    }
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = speed_vec.normalized * speed;
        Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 8.72f;
        }
        else
        {
            speed = 5f;
        }
        speed_vec = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IsLeftWalk", true);
            speed_vec.x -= speed;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("IsLeftWalk", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsRightWalk", true);
            speed_vec.x += speed;
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
                anim.SetBool("IsRightWalk", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("IsBackWalk", true);
            
            speed_vec.y += speed;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("IsBackWalk", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("IsWalk", true);
            
            speed_vec.y -= speed;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("IsWalk", false);
        }
        speed_vec.Normalize();
    }
 }


