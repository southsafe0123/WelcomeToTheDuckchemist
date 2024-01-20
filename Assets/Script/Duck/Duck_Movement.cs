using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Duck_Movement : MonoBehaviour
{
    private Vector2 mousePos;
    private bool move;
    public float speed;
    public Rigidbody2D rb;
    public enum State
    {
        moving,
        idle
    }

    public State state;

    // Update is called once per frame
    void Update()
    {
        ClickPos();
        CheckState();
    }

    private void FixedUpdate()
    {
        if(move)
        {
            Move();
        }
    }

    void ClickPos()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.y = transform.position.y;
            state = State.moving;
        }
    }

    void CheckState()
    {
        switch (state)
        {
            case State.moving:
                move = true;
                break;
            case State.idle:
                move = false;
                break;
        }
    }

    private void Move()
    {
        if (transform.position.x != mousePos.x)
        {
            transform.position = Vector2.MoveTowards(transform.position, mousePos, speed * Time.fixedDeltaTime);
        }
        else
        {
            state = State.idle;
        }
    }
}
