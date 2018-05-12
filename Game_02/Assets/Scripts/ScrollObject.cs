using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour {

    private Rigidbody2D rigid;
	void Awake () {
        rigid = GetComponent<Rigidbody2D>();
       
	}
    private void Start()
    {
        rigid.velocity = new Vector2(-GameMode._instance.scollSpeed, 0);
    }

    // Update is called once per frame
    void Update () {
        if (GameMode._instance.isGameOver)
        {
            StopScroll();
        }
	}
    void StopScroll()
    {
        rigid.velocity = Vector2.zero;
    }

}
