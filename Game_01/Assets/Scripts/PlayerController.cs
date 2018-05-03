using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private PlayerCharacter playerCharacter;
    private PlayerCamera playerCamera;
    private GameMode gameMode;

    void Awake()
    {
        playerCharacter = FindObjectOfType<PlayerCharacter>();
        playerCamera = FindObjectOfType<PlayerCamera>();
        gameMode = FindObjectOfType<GameMode>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (gameMode.isGameEnd) return;
        PlayerMove();
        PlayerJump();

    }

    void PlayerMove()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        Transform cameraTrans = playerCamera.transform;
        Vector3 dir = (h * cameraTrans.right + v * cameraTrans.forward).normalized;

        playerCharacter.Move(dir);
   
    }
    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerCharacter.Jump();
        }
    }

    public void OnClick_ResetGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Start");
        Time.timeScale = 1;
    }
}
