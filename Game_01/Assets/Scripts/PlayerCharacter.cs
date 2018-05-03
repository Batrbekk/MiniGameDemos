using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter: MonoBehaviour {
    Rigidbody rigidbody;
    public float speed = 5;
    public float jumpForce = 0.8f;
    public AudioClip dieSound;
    private PlayerHUD hud;
    private int score = 0;
    public int Score { get { return score; } }
    private bool isAlive = true;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        hud = FindObjectOfType<PlayerHUD>();
    }
    private void Update()
    {
        
        if (transform.position.y < -20&&isAlive)
        {
            Die();
        }
    }

    public void Move(Vector3 dir)
    {
        rigidbody.AddForce(dir*speed,ForceMode.Acceleration);
    }
    public void Jump()
    {
        if (Physics.Raycast(transform.position, Vector3.down, 0.6f))
        {
            rigidbody.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
        }
    }
    public void AddScore()
    {
        score++;
    }
    private void  Die()
    {
        isAlive = false;
        AudioSource.PlayClipAtPoint(dieSound, transform.position);
        hud.ShowEndPanel();
        Invoke("PauseGame", 2);
    }
    public void CompleteLevel()
    {
       
        AudioSource.PlayClipAtPoint(dieSound, transform.position);
        hud.ShowEndPanel();
        Invoke("PauseGame", 0.5f);
    }
   
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}
