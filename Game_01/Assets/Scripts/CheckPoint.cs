using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public AudioClip gameEndSound;

 
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            var player = other.GetComponent<PlayerCharacter>();
            gameObject.SetActive(false);
            player.CompleteLevel();
            AudioSource.PlayClipAtPoint(gameEndSound, transform.position);
            


        }
    }
}
