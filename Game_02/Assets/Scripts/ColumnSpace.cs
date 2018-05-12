using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpace : MonoBehaviour {

    BoxCollider2D trigger;
    Transform childUp;
    Transform childDown;
    void Awake () {
        trigger = GetComponent<BoxCollider2D>();
        childDown = transform.GetChild(0);
        childUp= transform.GetChild(1);
    }
	
	

    public void AddDegree()
    {
        trigger.size = new Vector2(trigger.size.x, trigger.size.y-0.1f);
        childDown.position = new Vector2(childDown.position.x, childDown.position.y+0.05f);
        childUp.position = new Vector2(childUp.position.x, childUp.position.y-0.05f);
        
    }
}
