using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("start");
        //OnContactWithPlayer(collision);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void OnContactWithPlayer(Collision collision)
    //{
    //    PlayerDeath player = collision.GetComponent<PlayerDeath>();

    //    if (player != null)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    public void OnTriggerEnter(Collider collision)
    {
        PlayerDeath died = collision.GetComponent<PlayerDeath>();

        if (died != null)
        {
            died.Dead();
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
}
