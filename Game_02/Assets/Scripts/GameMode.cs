using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour {

    public static GameMode _instance;
    public bool isGameOver = false;
    public float scollSpeed = 2;
    public GameObject gameOverText;
    public Text scoreText;
    public AudioClip addScore;
    public int score = 0;
    private ColumnController columnCobtroller;
	void Awake () {
        _instance = this;
        columnCobtroller = FindObjectOfType<ColumnController>();
	}
	
	
	void Update () {
        if (isGameOver && Input.GetMouseButtonDown(0))
        {
            Invoke("ReStartGame", 0.1f);
        }
	}
    public void AddScore()
    {
        score++;
        scoreText.text = "SCORE:	" + score;
        AudioSource.PlayClipAtPoint(addScore, transform.position);
        if (score %10==0)
        {
            GameDegree();
       
        }
    }
    public void GameOver()
    {
        gameOverText.SetActive(true);
     
    }
    void ReStartGame()
    {
        SceneManager.LoadScene("Start");
    }
    
    void GameDegree()
    {
        scollSpeed = 2 + score / 100;
        columnCobtroller.AddDegree();
    }
}
