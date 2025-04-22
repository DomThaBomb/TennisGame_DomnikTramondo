using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerPawnInput player;

    // Movement Spheres
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
        RenderInput(); 
    }

    public void RenderInput()
    {
        if (Input.GetKey(moveUp))
        {
            // move up

            player.MoveUp();
        }
        if (Input.GetKey(moveDown))
        {
            // move down

            player.MoveDown();
        }
        if (Input.GetKey(moveLeft))
        {
            // move left

            player.MoveLeft();
        }
        if (Input.GetKey(moveRight))
        {
            // move right

            player.MoveRight();
        }
    }
}
