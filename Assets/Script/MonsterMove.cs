using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMove : MonoBehaviour {

    // Use this for initialization
    public GameObject[] gameObjects;
    int temp = 0;
	void Start ()
    {
        temp = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, gameObjects[temp].transform.position,Time.deltaTime*2);
        if (Vector3.Distance(this.transform.position, gameObjects[temp].transform.position) < 0.1f)
        {
            if (temp == 0)
            {
                temp = 1;
            }
            else
                temp = 0;
        }
	}
}
