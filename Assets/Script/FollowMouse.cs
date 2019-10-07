using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FollowMouse : MonoBehaviour {

    public List<Transform> BodyParts = new List<Transform>();
    private Transform curBodyPart;
    private Transform prevBodyPart;
    private float distance;
     float LerpTimeX;
     float LerpTimeY;
    public GameObject BodyPrefab;
    public GameObject BodyPrefab1;
    float moveSpeed = 8.0f;
    float SpeedTime;
    bool bProtect;
    public  int Score;
    public Text[] texts;
    public GameObject End;
    public GameObject Win;
    public GameObject Lockobj;

    public AudioClip[] audios;

    public GameObject Last;

    float CreateItem;
    public GameObject[] FKItem;
    public GameObject itemvec;
    //public GameObject This;
    void Start()
    {
        CreateItem = 1;
        Score =40;
        SpeedTime = 1;
        Time.timeScale = 1;
        BodyParts.Add(this.transform);
        for (int i = 0; i < 4; i++)
        {
            AddBodyPart();
        }
        if (BeginScence. bSoundBg)
        {
            Camera.main.GetComponent<AudioSource>().clip = audios[0];
            Camera.main.GetComponent<AudioSource>().loop = true;
            Camera.main.GetComponent<AudioSource>().Play();
        }
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            CreateItem = 2;
            int tempnum = Random.Range(3, 7);

            GameObject gameObject = GameObject.Instantiate(FKItem[2]);
            gameObject.transform.position = new Vector3(this.transform.position.x + 40, 6.64f, 0);
            gameObject.transform.GetChild(0).name = tempnum.ToString();

            if (tempnum == 3)
            {
                gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.red;
               
            }
            if (tempnum == 4)
            {
                gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.green;
               
            }
            if (tempnum == 5)
            {
                gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.blue;
               
            }
            if (tempnum == 6)
            {
                gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.gray;
               
            }
        }
    }
    // Update is called once per frame	
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (BeginScence.bSoundOther)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audios[1], BeginScence.SoundOther);
            }
        }
        texts[0].text = Score.ToString();
        texts[1].text = Score.ToString();
        texts[3].text = Score.ToString();
        texts[2].text = (BodyParts.Count-1).ToString();
        if (Time.timeScale == 0)
            return;
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            CreateItem -= Time.deltaTime;
            if (CreateItem <= 0)
            {
                CreateItem = 2;
                int temp1 = Random.Range(0, 6);
                if (temp1 == 1 || temp1 == 2)
                {
                    int temp2 = Random.Range(1, 5);
                    GameObject gameObject = GameObject.Instantiate(FKItem[3]);
                    gameObject.transform.position = new Vector3(this.transform.position.x + 40, 6.64f, 0);
                    for (int i = 0; i < temp2; i++)
                    {
                        int temp3 = Random.Range(0, 4);
                        while (gameObject.transform.GetChild(temp3).gameObject.activeSelf)
                        {
                            temp3 = Random.Range(0, 4);
                        }
                        gameObject.transform.GetChild(temp3).gameObject.SetActive(true);                                                                
                    }
                }
                else if (temp1 == 3 || temp1 == 4 || temp1 == 5)
                {
                    int temp2 = Random.Range(1, 5);
                    GameObject gameObject = GameObject.Instantiate(FKItem[4]);
                    gameObject.transform.position = new Vector3(this.transform.position.x + 40, 6.64f, 0);
                    for (int i = 0; i < temp2; i++)
                    {
                        int temp3 = Random.Range(0, 4);
                        while (gameObject.transform.GetChild(temp3).gameObject.activeSelf)
                        {
                            temp3 = Random.Range(0, 4);
                        }
                        gameObject.transform.GetChild(temp3).gameObject.SetActive(true);
                    }
                }
                else
                {
                    int tempnum = Random.Range(3, 7);

                    GameObject gameObject = GameObject.Instantiate(FKItem[2]);
                    gameObject.transform.position = new Vector3(this.transform.position.x + 40, 6.64f, 0);
                    gameObject.transform.GetChild(0).name = tempnum.ToString();
                    //this.tag = tempnum.ToString();
                    if (tempnum == 3)
                    {
                        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.red;
                      
                    }
                    if (tempnum == 4)
                    {
                        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.green;
                       
                    }
                    if (tempnum == 5)
                    {
                        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.blue;
                       
                    }
                    if (tempnum == 6)
                    {
                        gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.gray;
                        
                    }
                }
            }

        }
        if (SceneManager.GetActiveScene().buildIndex == 2 )
        {
            CreateItem -= Time.deltaTime;
            if (CreateItem <= 0)
            {
                CreateItem = 2;
                int temp1 = Random.Range(0,6);
                if (temp1 == 1|| temp1 == 2)
                {
                    int temp2 = Random.Range(1, 7);
                    GameObject gameObject = GameObject.Instantiate(FKItem[0]);
                    gameObject.transform.position = new Vector3(this.transform.position.x + 40, 6.64f, 0);
                    for (int i = 0; i < temp2; i++)
                    {
                        int temp3 = Random.Range(0, 6);
                        while (gameObject.transform.GetChild(temp3).gameObject.activeSelf)
                        {
                            temp3 = Random.Range(0, 6);
                        }
                        gameObject.transform.GetChild(temp3).gameObject.SetActive(true);
                        int temp4 = Random.Range(1, 10);
                        gameObject.transform.GetChild(temp3).name = temp4.ToString();
                        gameObject.transform.GetChild(temp3).GetChild(0).GetComponent<TextMesh>().text = temp4.ToString();
                    }
                }
                if (temp1 == 3|| temp1 == 4|| temp1 == 5)
                {
                    GameObject gameObject = GameObject.Instantiate(FKItem[1]);
                    gameObject.transform.position = new Vector3(this.transform.position.x + 40, 6.64f, 0);
                    for (int i = 0; i < 4; i++)
                    {
                        int temp4 = Random.Range(1, 10);
                        gameObject.transform.GetChild(i).name = temp4.ToString();
                        gameObject.transform.GetChild(i).GetChild(0).GetComponent<TextMesh>().text = temp4.ToString();
                    }
                }
            }

        }
        FollowMouseRotate();
        FollowMouseMove();
        if (SpeedTime <= 0)
        {
            moveSpeed = 8.0f;
            SpeedTime = 0;
        }
        else
        {
            SpeedTime -= Time.deltaTime;
        }
    }
    //物体跟随鼠标旋转    
    private void FollowMouseRotate()
    {
       // float x = Input.GetAxis("Mouse X");
       // float y = Input.GetAxis("Mouse Y");
      
            //获取鼠标的坐标，鼠标是屏幕坐标，Z轴为0，这里不做转换          
            Vector3 mouse = Input.mousePosition;
            //获取物体坐标，物体坐标是世界坐标，将其转换成屏幕坐标，和鼠标一直          
            Vector3 obj = Camera.main.WorldToScreenPoint(transform.position);
        //屏幕坐标向量相减，得到指向鼠标点的目标向量，即黄色线段 
   
        if (SceneManager.GetActiveScene().buildIndex != 2 && SceneManager.GetActiveScene().buildIndex != 3)
        {
            mouse = mouse + 500 * transform.up;
        }
           
        Vector3 direction = mouse - obj;
        
            //将Z轴置0,保持在2D平面内          
            direction.z = 0f;
     if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            direction.x = 400;

         }
            //将目标向量长度变成1，即单位向量，这里的目的是只使用向量的方向，不需要长度，所以变成1          
            direction = direction.normalized;
            //物体自身的Y轴和目标向量保持一直，这个过程XY轴都会变化数值          
            transform.up = direction;
        //float moveSpeed = 6.0f;
        //transform.Translate(direction * moveSpeed * Time.deltaTime);
       
    }
    //跟随鼠标移动   
    private void FollowMouseMove()
    {
     
      
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
     
        for (int i = 1; i < BodyParts.Count; i++)
        {
            curBodyPart = BodyParts[i];
            prevBodyPart = BodyParts[i - 1];

            distance = Vector3.Distance(prevBodyPart.position, curBodyPart.position);
            if (distance > 0.6f)
            {
                LerpTimeX = LerpTimeY = 0.1f;
            }
            else
            {
                LerpTimeX = LerpTimeY = 0.02f;
            }
                Vector3 newPos = prevBodyPart.position;

                newPos.z = BodyParts[0].position.z;

                //Try 2 Lerps, one on the x pos and one on the Y
                Vector3 pos = curBodyPart.position;

                pos.x = Mathf.Lerp(pos.x, newPos.x, LerpTimeX);
                pos.y = Mathf.Lerp(pos.y, newPos.y, LerpTimeY);

                curBodyPart.position = pos;
           

         


        }
    }
    public void AddBodyPart()
    {
        Transform newPart;
        if (BodyParts.Count == 0)
        {
            newPart = (Instantiate(BodyPrefab, transform.position,
       transform.rotation) as GameObject).transform;
            newPart.SetParent(transform.parent);
            BodyParts.Add(newPart);
        }
        else
        {
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                newPart = (Instantiate(BodyPrefab1, BodyParts[BodyParts.Count - 1].position,
            BodyParts[BodyParts.Count - 1].rotation) as GameObject).transform;
                newPart.SetParent(BodyParts[BodyParts.Count - 1].parent);
                BodyParts.Add(newPart);
            }
            else
            {
                newPart = (Instantiate(BodyPrefab, BodyParts[BodyParts.Count - 1].position,
            BodyParts[BodyParts.Count - 1].rotation) as GameObject).transform;
                newPart.SetParent(BodyParts[BodyParts.Count - 1].parent);
                BodyParts.Add(newPart);
            }
        }
       

    }
    public void DelateBodyPart()
    {
        if (BodyParts.Count > 1)
        {
            Destroy(BodyParts[BodyParts.Count - 1].gameObject);
            BodyParts.RemoveAt(BodyParts.Count - 1);
        }
        else
        {
            Time.timeScale = 0;
            End.SetActive(true);
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Food")
        {
            if (BeginScence.bSoundOther)
            {


                this.GetComponent<AudioSource>().PlayOneShot(audios[3], BeginScence.SoundOther);
            }
            Score += 10;
            AddBodyPart();
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Boom")
        {
            if (bProtect)
            {
                bProtect = false;
            }
            else
            {
                if (BeginScence.bSoundOther)
                {


                    this.GetComponent<AudioSource>().PlayOneShot(audios[2], BeginScence.SoundOther);
                }
                int num = (BodyParts.Count) / 2;
                for (int i = 0; i < num; i++)
                {
                    if (BodyParts.Count > 1)
                    {
                        Score -= 5;
                        DelateBodyPart();
                    }
                    else
                    {
                        Time.timeScale = 0;
                        End.SetActive(true);
                    }
                }
            }
          
            Destroy(collision.gameObject);
        }
        if (collision.tag == "AddSpeed")
        {
            if (BeginScence.bSoundOther)
            {


                this.GetComponent<AudioSource>().PlayOneShot(audios[4], BeginScence.SoundOther);
            }
            moveSpeed = 10;
            SpeedTime = 10;
            Destroy(collision.gameObject);
        }
        if (collision.tag == "BigFood")
        {
            if (BeginScence.bSoundOther)
            {


                this.GetComponent<AudioSource>().PlayOneShot(audios[3], BeginScence.SoundOther);
            }
            int num = (BodyParts.Count );
            for (int i = 0; i < num; i++)
            {
                Score += 10;
                AddBodyPart();
            }
            Destroy(collision.gameObject);

        }
        if (collision.tag == "Sheild")
        {
            if (BeginScence.bSoundOther)
            {


                this.GetComponent<AudioSource>().PlayOneShot(audios[5], BeginScence.SoundOther);
            }
            bProtect = true;
            Destroy(collision.gameObject);
        }
        if (collision.tag == "BigBoom")
        {
            if (bProtect)
            {
                bProtect = false;
            }
            else
            {
                if (BeginScence.bSoundOther)
                {


                    this.GetComponent<AudioSource>().PlayOneShot(audios[7], BeginScence.SoundOther);
                }
                int num =  2;
                for (int i = 0; i < num; i++)
                {
                    if (BodyParts.Count > 1)
                    {
                        Score -= 5;
                        DelateBodyPart();
                    }
                    else
                    {
                        Time.timeScale = 0;
                        End.SetActive(true);
                    }
                  
                }
            }

            Destroy(collision.gameObject);
        }
        if (collision.tag == "Key")
        {
            Lockobj.SetActive(false);
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Next")
        {
            Time.timeScale = 0;
            Win.SetActive(true);
        }
        if (collision.tag == "Monster")
        {
            Time.timeScale = 0;
            End.SetActive(true);
        }
        if (collision.tag == "Map")
        {
            if (Last == null)
            {
                Last = collision.gameObject;
            }
            else
            {
                Last.transform.position = collision.transform.position+new Vector3 (48,0,0);
                Last = collision.gameObject;
            }
        }
        if (collision.tag == "1")
        {
            for (int i = 0; i < int.Parse(collision.name); i++)
            {
                Score += 10;
                AddBodyPart();
            }
            Destroy(collision.gameObject);
        }
        if (collision.tag == "2")
        {
            for (int i = 0; i < int.Parse(collision.name); i++)
            {
                Score -= 5;
                DelateBodyPart();
            }
            Destroy(collision.gameObject);
        }
        if (collision.tag == "3")
        {
            if (this.gameObject.tag != "3")
            {
                Time.timeScale = 0;
                End.SetActive(true);
            }
            else
            {
                Score += 10;
            }
        }
        if (collision.tag == "4")
        {
            if (this.gameObject.tag != "4")
            {
                Time.timeScale = 0;
                End.SetActive(true);
            }
            else
            {
                Score += 10;
            }
        }
        if (collision.tag == "5")
        {
            if (this.gameObject.tag != "5")
            {
                Time.timeScale = 0;
                End.SetActive(true);
            }
            else
            {
                Score += 10;
            }
        }
        if (collision.tag == "6")
        {
            if (this.gameObject.tag != "6")
            {
                Time.timeScale = 0;
                End.SetActive(true);
            }
            else
            {
                Score += 10;
            }
        }
        if (collision.tag == "7")
        {
            if (collision.name =="3")
            {
                for (int i = 1; i < BodyParts.Count; i++)
                {
                    BodyParts[i].GetComponent<SpriteRenderer>().color = Color.red;
                }

            }
            if (collision.name == "4")
            {
                for (int i = 1; i < BodyParts.Count; i++)
                {
                    BodyParts[i].GetComponent<SpriteRenderer>().color = Color.green;
                }

            }
            if (collision.name == "5")
            {
                for (int i = 1; i < BodyParts.Count; i++)
                {
                    BodyParts[i].GetComponent<SpriteRenderer>().color = Color.blue;
                }

            }
            if (collision.name == "6")
            {
                for (int i = 1; i < BodyParts.Count; i++)
                {
                    BodyParts[i].GetComponent<SpriteRenderer>().color = Color.gray;
                }

            }
          
            this.gameObject.tag = collision.name;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (BeginScence.bSoundOther)
            {
                this.GetComponent<AudioSource>().PlayOneShot(audios[6], BeginScence.SoundOther);
            }
            Time.timeScale = 0;
            End.SetActive(true);
        }
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Next()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 <= 7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }  
        else
            SceneManager.LoadScene(0);
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }

}
