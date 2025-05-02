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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveUp()
    {
        if (movementForces != null)
        {
            Vector3 movement = new Vector3(0, 0, movementForces.position.z);

            // Vector3 movement = transform.forward;
            // playerMovement.forward;

            movementForces.AddForce(movement * speed * Time.deltaTime);

            // transform.position = transform.position + (movement * speed * Time.deltaTime);
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
        if (movementForces != null)
        {
            Vector3 movement = new Vector3(0, 0, -movementForces.position.z);

            // Vector3 movement = -transform.forward;
            // -playerMovement.forward; 

            movementForces.AddForce(movement * speed * Time.deltaTime);

            // transform.position = transform.position + (movement * speed * Time.deltaTime);
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
        if (movementForces != null)
        {
            Vector3 movement = new Vector3(-movementForces.position.x, 0, 0);

            // Vector3 movement = -transform.right;
            //-playerMovement.right;

            movementForces.AddForce(movement * speed * Time.deltaTime);

            // transform.position = transform.position + (movement * speed * Time.deltaTime);
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
        if (movementForces != null)
        {
            Vector3 movement = new Vector3(movementForces.position.x, 0, 0);

            // Vector3 movement = transform.right;
            // playerMovement.right;

            movementForces.AddForce(movement * speed * Time.deltaTime);

            // transform.position = transform.position + (movement * speed * Time.deltaTime);
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
