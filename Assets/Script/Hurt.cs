using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour {

    public GameObject Sneke; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Snake")
        {
            Sneke.GetComponent<FollowMouse>().Score -= 5;
            Sneke.SendMessage("DelateBodyPart");
            Debug.Log("11");
         }
    }
}
