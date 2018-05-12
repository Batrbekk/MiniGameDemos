using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnController : MonoBehaviour {

    public GameObject columnPrefab;

    private float maxY = 3.5f;
    private float minY = -4;
    private float posX = 5;
    private int maxColumn = 6;
    GameObject[] columns;
    Vector2 originalPos = new Vector2(-10, -10);
    float spawnRate=3;
    float timeSincelastSpawned = 0;
    int currentColumn = 0;


	void Start () {
        columns = new GameObject[maxColumn];
        for(int i = 0; i < maxColumn; i++)
        {
            columns[i] = Instantiate(columnPrefab, originalPos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSincelastSpawned += Time.deltaTime;
        if (GameMode._instance.isGameOver == false && timeSincelastSpawned >= spawnRate)
        {
            timeSincelastSpawned = 0;
            Spawn();
        }
	}
    void Spawn()
    {
        float posY = Random.Range(minY, maxY);
            columns[currentColumn].transform.position = new Vector2(posX, posY);
            currentColumn++;
            print(currentColumn);
        if (currentColumn >= maxColumn)
        {
            currentColumn = 0;
        }


    }

    public void AddDegree()
    {
      
       
            columns[currentColumn].GetComponent<ColumnSpace>().AddDegree();
       
    }
}
