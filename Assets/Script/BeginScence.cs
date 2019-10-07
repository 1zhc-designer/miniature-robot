using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginScence : MonoBehaviour {

    public GameObject[] AllUi;
    public GameObject[] HelpUi;
    public GameObject[] SettingUi;

    public AudioClip[] audios;
    public static float SoundBg;
    public static float SoundOther;
    public static bool bSoundBg;
    public static bool bSoundOther;
    // Use this for initialization
    void Start ()
    {
        bSoundBg = true;
        bSoundOther = true;
        SoundBg = 1;
        SoundOther = 1;
        if (bSoundBg)
        {
            Camera.main.GetComponent<AudioSource>().clip = audios[0];
            Camera.main.GetComponent<AudioSource>().loop = true;
            Camera.main.GetComponent<AudioSource>().Play();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (AllUi[1].activeSelf)
        {
            bSoundBg = SettingUi[0].GetComponent<Toggle>().isOn;
            bSoundOther = SettingUi[1].GetComponent<Toggle>().isOn;
            SoundBg = SettingUi[2].GetComponent<Slider>().value;
            SoundOther = SettingUi[3].GetComponent<Slider>().value;
            Camera.main.GetComponent<AudioSource>().volume = SoundBg;
            if (!bSoundBg)
            {
                if (Camera.main.GetComponent<AudioSource>().isPlaying)
                    Camera.main.GetComponent<AudioSource>().Stop();
            }
            else
            {
                if (!Camera.main.GetComponent<AudioSource>().isPlaying)
                {
                    Camera.main.GetComponent<AudioSource>().Play();
                } 
            }
           
        }
      
       
        if (Input.GetMouseButtonDown(0))
        {
            if (bSoundOther)
            {
            
              
                this.GetComponent<AudioSource>().PlayOneShot(audios[1], SoundOther);
            }
        }
       
    }
    public void PlayGame()
    {
        AllUi[0].SetActive(true);
    }
    public void PlayGame1()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayGame4()
    {
        SceneManager.LoadScene(4);
    }
    public void PlayGame5()
    {
        SceneManager.LoadScene(5);
    }
    public void PlayGame6()
    {
        SceneManager.LoadScene(6);
    }
    public void PlayGame7()
    {
        SceneManager.LoadScene(7);
    }
    public void GuanKa()
    {
        AllUi[3].SetActive(true);
    }
    public void GuanKaReturn()
    {
        AllUi[3].SetActive(false);
    }
    public void PlayGamereturn()
    {
        AllUi[0].SetActive(false);
    }
    public void Setting()
    {
        AllUi[1].SetActive(true);
    }
    public void Settingreturn()
    {
        AllUi[1].SetActive(false);
    }
    public void Help()
    {
        AllUi[2].SetActive(true);
        for (int i = 0; i < HelpUi.Length; i++)
        {
            HelpUi[i].SetActive(false);
        }
        HelpUi[0].SetActive(true);
    }
    public void Help1()
    {
        for (int i = 0; i < HelpUi.Length; i++)
        {
            HelpUi[i].SetActive(false);
        }
        HelpUi[0].SetActive(true);
    }
    public void Help2()
    {
        for (int i = 0; i < HelpUi.Length; i++)
        {
            HelpUi[i].SetActive(false);
        }
        HelpUi[1].SetActive(true);
    }
    public void Help3()
    {
        for (int i = 0; i < HelpUi.Length; i++)
        {
            HelpUi[i].SetActive(false);
        }
        HelpUi[2].SetActive(true);
    }
    public void Help4()
    {
        for (int i = 0; i < HelpUi.Length; i++)
        {
            HelpUi[i].SetActive(false);
        }
        HelpUi[3].SetActive(true);
    }
    public void Helpreturn()
    {
        AllUi[2].SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
