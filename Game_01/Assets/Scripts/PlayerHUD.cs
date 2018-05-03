using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHUD : MonoBehaviour {


    public Text text;
    public GameObject gameEndPanel;
    private PlayerCharacter player;
    private GameMode gameMode;
    private void Awake()
    {
        player = FindObjectOfType<PlayerCharacter>();
        gameMode= FindObjectOfType<GameMode>();
    }

    // Update is called once per frame
    void Update () {
        text.text = "Coin Count: " + player.Score;
	}

    public void  ShowEndPanel()
    {
        gameEndPanel.SetActive(true);
        gameMode.isGameEnd = true;
    }
}
