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
            // Vector3 Rmovement = new Vector3(0, 0, -RacketMovementForce.position.z);

            Vector3 Rmovement = -transform.up;

            // RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);

            transform.position = transform.position + (Rmovement * speed * Time.deltaTime); 
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
            // Vector3 Rmovement = new Vector3(0, 0, RacketMovementForce.position.z);

            Vector3 Rmovement = transform.up;

            // RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);

            transform.position = transform.position + (Rmovement * speed * Time.deltaTime);
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
            // Vector3 Rmovement = new Vector3(-RacketMovementForce.position.x, 0, 0);

            Vector3 Rmovement = -transform.right;

            // RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);

            transform.position = transform.position + (Rmovement * speed * Time.deltaTime);
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
            // Vector3 Rmovement = new Vector3(RacketMovementForce.position.x, 0, 0);

            Vector3 Rmovement = transform.right;

            // RacketMovementForce.AddForce(Rmovement * speed * Time.deltaTime);

            transform.position = transform.position + (Rmovement * speed * Time.deltaTime);
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
