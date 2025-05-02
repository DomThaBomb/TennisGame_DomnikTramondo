using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;

    public void Dead() 
    {
        Destroy(gameObject);
    }
}
