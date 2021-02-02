using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Animator animator;

    Transform Transform;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    bool facingRight = true;

    Vector2 movement;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + movement * moveSpeed);

        if ((Input.GetKey(KeyCode.LeftShift)) && (EnergyBar.energy >= 1))
        {
            rb.MovePosition(rb.position + movement * (moveSpeed * 1.3f));
            EnergyBar.energy -= 0.5f;
        }
        else if (EnergyBar.energy < 100)
        {
            EnergyBar.energy += 0.2f;
        }
    }

    void Update()
    {
        if (Input.GetKey("d")){
             if(transform.rotation != Quaternion.Euler(0, 0, 0))
                 transform.rotation = Quaternion.Euler(0, 0, 0);
        }
         
         if (Input.GetKey("a")){
            if(transform.rotation != Quaternion.Euler(0, 180, 0))
            transform.rotation = Quaternion.Euler(0, 180, 0);
         }


            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("IsWalking", true);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetBool("IsWalking", false);
            }
            if (Input.GetKey(KeyCode.A))
            {
                animator.SetBool("IsWalking", true);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("IsWalking", true);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetBool("IsWalking", false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                animator.SetBool("IsWalking", true);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("IsWalking", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool("IsWalking", false);
            }
            if (Input.GetKey(KeyCode.W))
            {
                animator.SetBool("IsWalking", true);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.SetBool("IsWalking", true);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                animator.SetBool("IsWalking", false);
            }
            if (Input.GetKey(KeyCode.S))
            {
                animator.SetBool("IsWalking", true);
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
            {
                animator.SetBool("IsWalking", false);
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
            {
                animator.SetBool("IsWalking", false);
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
                animator.SetBool("IsWalking", true);
            }
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
            {
            animator.SetBool("IsWalking", true);
            }
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
            {
            animator.SetBool("IsWalking", true);
            }
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.W))
            {
                animator.SetBool("IsWalking", true);
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
            {
                animator.SetBool("IsWalking", false);
            }
        }
    }