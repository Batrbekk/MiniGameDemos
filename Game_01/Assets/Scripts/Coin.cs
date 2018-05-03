using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    PlayerCharacter player;
    public AudioClip pickUpSound;

    private void Awake()
    {
        player = FindObjectOfType<PlayerCharacter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.AddScore();
            gameObject.SetActive(false);
            AudioSource.PlayClipAtPoint(pickUpSound, transform.position);

        }
    }
}
