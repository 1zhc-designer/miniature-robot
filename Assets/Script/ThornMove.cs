using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornMove : MonoBehaviour {
    public GameObject Sneke;
    float CreateTime;
    public float BeginTime;
   public  bool bmove;

    public bool bCreate;
    int TriggerTime;
	// Use this for initialization
	void Start () {
        //bmove = false;
        CreateTime = BeginTime;
        TriggerTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
       
        if (bmove)
        {
            this.transform.Translate(Vector3.up*Time.deltaTime*5, Space.Self);
        }
        if (bCreate)
            return;
        if (CreateTime > 0)
        {
            CreateTime -= Time.deltaTime;
        }
        else
        {
            CreateTime = BeginTime;
            GameObject gameObject = GameObject.Instantiate(this.gameObject);
            gameObject.transform.SetParent(this.transform.parent);
            gameObject.transform.position = this.transform.position;
            gameObject.transform.GetComponent<ThornMove>().bmove = true;
            gameObject.transform.GetComponent<ThornMove>().bCreate = true;
            gameObject.transform.GetComponent<ThornMove>().Sneke = Sneke;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Snake")
        {
            Sneke.GetComponent<FollowMouse>().Score -= 5;
            Sneke.SendMessage("DelateBodyPart");
            Debug.Log("11");
        }
        if (collision.tag == "SecWall")
        {
            TriggerTime++;
           // Debug.Log(TriggerTime);
            if (TriggerTime == 2)
            {
                Destroy(this.gameObject);
            }
           
        }
    }
}
