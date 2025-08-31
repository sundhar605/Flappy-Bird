using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpvelocity =20;
    public logic_script logic;
    public bool is_alive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && is_alive ==true)
        {
            rb.linearVelocity = Vector2.up * jumpvelocity;
        }
        if(transform.position.y > 20 || transform.position.y < -20)
        {
            logic.game_over();
            is_alive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.game_over();
        is_alive = false;
    }
}
