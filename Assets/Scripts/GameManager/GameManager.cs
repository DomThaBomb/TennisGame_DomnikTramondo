using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public GameObject player;

    // Scording System
    private int scoring = 15;
    private int maxscore = 55;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddTennisScore()
    {
        scoring++;
    }

    public void GameEnd()
    {
        maxscore = score;
    }

    private void DestroyObject() 
    {
        Destroy(player);
        AddTennisScore();
    }
}
