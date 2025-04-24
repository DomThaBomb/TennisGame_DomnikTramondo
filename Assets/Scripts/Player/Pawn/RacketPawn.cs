using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPawn : MonoBehaviour
{
    public Rigidbody RacketMovementForce;
    public Transform playerRacketMovement;

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
        if (RacketMovementForce != null)
        {
            Vector3 Rmovement = -playerRacketMovement.forward; // new Vector3(0, 0, -movementForces.position.z);

            RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);
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
        if (RacketMovementForce != null)
        {
            Vector3 Rmovement = playerRacketMovement.forward;  // new Vector3(0, 0, movementForces.position.z);

            RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);
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
        if (RacketMovementForce != null)
        {
            Vector3 Rmovement = playerRacketMovement.right;// new Vector3(-movementForces.position.x, 0, 0);

            RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);
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
        if (RacketMovementForce != null)
        {
            Vector3 Rmovement = -playerRacketMovement.right; // new Vector3(movementForces.position.x, 0, 0);

            RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);
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
