using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroudRepeat : MonoBehaviour {

    BoxCollider2D boxc;
	void Awake () {
        boxc = GetComponent<BoxCollider2D>();
	}
	

	void Update () {
        BgRepeat();

    }
   void BgRepeat()
    {
        if (transform.position.x < -boxc.size.x)
        {
            transform.position = new Vector2(boxc.size.x, 0);
        }

    }
}
