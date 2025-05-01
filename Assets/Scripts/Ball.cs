using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public GameObject player;
    public Rigidbody BallForce;
    public Transform BallTransformMovement;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("start");
        //OnContactWithPlayer(collision);
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void OnContactWithPlayer(Collision collision)
    {
        PlayerPawnInput player = collision.gameObject.GetComponent<PlayerPawnInput>();

        if (collision != null)
        {
            Destroy(player);
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        OnContactWithPlayer (collision);
    }
}
