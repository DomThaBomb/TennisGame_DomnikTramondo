using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawnInput : MonoBehaviour
{
    // Declared variables and classes
    public Rigidbody movementForces;
    public Transform playerMovement;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        movementForces = GetComponent<Rigidbody>();
        playerMovement = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp()
    {
        Debug.Log("move up");

        if (movementForces != null)
        {
            Vector3 movement = new Vector3(0, 0, -1);

            movementForces.AddForce(movement * speed * Time.deltaTime);
        }
        // if (audioSource != null)
        {
            // if (!audioSource.isPlaying)
            {
                // audioSource.Play();
            }
        }
    }
    public void MoveDown()
    {
        Debug.Log("move down");

        if (movementForces != null)
        {
            Vector3 movement = new Vector3(0, 0, 1);

            movementForces.AddForce(movement * speed * Time.deltaTime);
        }
        // if (audioSource != null)
        {
            // if (!audioSource.isPlaying)
            {
                // audioSource.Play();
            }
        }
    }
    public void MoveLeft()
    {
        Debug.Log("move left");

        if (movementForces != null)
        {
            Vector3 movement = new Vector3(1, 0, 0);

            movementForces.AddForce(movement * speed * Time.deltaTime);
        }
        // if (audioSource != null)
        {
            // if (!audioSource.isPlaying)
            {
                // audioSource.Play();
            }
        }
    }
    public void MoveRight()
    {
        Debug.Log("move right");

        if (movementForces != null)
        {
            Vector3 movement = new Vector3(-1, 0, 0);

            movementForces.AddForce(movement * speed * Time.deltaTime);
        }
        // if (audioSource != null)
        {
            // if (!audioSource.isPlaying)
            {
                // audioSource.Play();
            }
        }
    }
}
