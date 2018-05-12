using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    PlayerCharacter player;
	void Awake () {
        player = GetComponent<PlayerCharacter>();
	}
	
	
	void Update () {
        if (Input.GetMouseButtonDown(0)&&GameMode._instance.isGameOver==false&&player.transform.position.y<5.0f)
        {
            player.GoUp();
        }
	}
}
