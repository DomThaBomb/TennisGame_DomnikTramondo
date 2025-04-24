using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    public RacketPawn racket;

    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderRacketInput();
    }

    public void RenderRacketInput()
    {
        if (Input.GetKey(moveUp))
        {
            // move up

            racket.MoveUp();
        }
        if (Input.GetKey(moveDown))
        {
            // move down

            racket.MoveDown();
        }
        if (Input.GetKey(moveLeft))
        {
            // move left

            racket.MoveLeft();
        }
        if (Input.GetKey(moveRight))
        {
            // move right

            racket.MoveRight();
        }
    }
}
