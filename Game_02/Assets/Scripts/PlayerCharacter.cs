using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    public float jumpForce = 220;

    public AudioClip hit;
    public AudioClip die;
    public AudioClip wing;

    Rigidbody2D rigd;
    Animator animator;
  

    void Awake () {
        rigd = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	

	void Update () {
		
	}

    public void GoUp()
    {
        rigd.velocity = Vector2.zero;
        animator.SetTrigger("GoUp");
        rigd.AddForce(new Vector2(0,jumpForce));
        AudioSource.PlayClipAtPoint(wing, transform.position);
    }
    public void Die()
    {
        animator.SetTrigger("Die");
        rigd.velocity = Vector2.zero;
        AudioSource.PlayClipAtPoint(die, transform.position);
        GameMode._instance.isGameOver = true;
        GameMode._instance.GameOver();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameMode._instance.isGameOver == false)
        {
            AudioSource.PlayClipAtPoint(hit, transform.position);
            Invoke("Die", 0.1f);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (GameMode._instance.isGameOver == false)
        {
            GameMode._instance.AddScore();
        }
    }
}
