using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class yonetici : MonoBehaviour
{

    bool oyundurdu = false;

    int skor = 0;
    int enyuksek;
    public int sesayar = 1;


    public Text skortxt;
    public Text sonskor;
    public Text enyuksekskor;

    public AudioSource sesdosya;
    public AudioClip pointses;

    public GameObject panel;
    public GameObject bittimenukapat;
    public GameObject durdurbutton;
    public GameObject clicker;

    public GameObject yildiz;
    public GameObject yildiz1;
    public GameObject yildiz2;
    public GameObject yildiz3;


    void Start()
    {
        
        sesayar = PlayerPrefs.GetInt("sesayart");
        if (sesayar == 0)
        {
            seskapali();
        }
        else
        {
            sesacik();
        }
        
        Invoke("clickkapat", 1.0f);
        Time.timeScale = 1.0f;
        InvokeRepeating("boruekle", 1.2f, 1.6f);
        skortxt.text = skor.ToString();
        
    }

    void clickkapat()
    {
        clicker.SetActive(false);       

    }
    public void tekrar_oynabtn()
    {        
        SceneManager.LoadScene("Scenes/recbird");
        Time.timeScale = 1.0f;
    }

    public void sesacik ()
    {
        sesdosya.Play();

    }

    public void seskapali ()
    {
        sesdosya.Stop();

    }

    public void seskis_btn()
    {
        
        if (sesayar == 0)
        {
            
            sesayar = 1;
            PlayerPrefs.SetInt("sesayart", sesayar);
            sesacik();
        }
        else if (sesayar == 1)
        {
            sesayar = 0;
            PlayerPrefs.SetInt("sesayart", sesayar);
            seskapali();
        }
    }

    public void play_btn()
    {
        oyundurdu = !oyundurdu;

        if (oyundurdu == true)
        {
            SceneManager.LoadScene("Scenes/recbird");
            Time.timeScale = 1.0f;
            

        }

        else
        {
            Time.timeScale = 0.0f;
            
        }
    }
    public void durdur_btn()
    {
        oyundurdu = !oyundurdu;

        if (oyundurdu == true)
        {
            durdurbutton.SetActive(false);
            bittimenukapat.SetActive(false);
            panel.SetActive(true);
            sesdosya.Pause();
            Time.timeScale = 0.0f;
            

        }

        else
        {
           
            panel.SetActive(false);
            durdurbutton.SetActive(true);
            Time.timeScale = 1.0f;
            sesdosya.UnPause();

        }
    }

    public void menu_btn()
    {
       
        if (oyundurdu == true)
        {

            SceneManager.LoadScene("Scenes/anamenu");
            Time.timeScale = 1.0f;

        }

        else
        {
            SceneManager.LoadScene("Scenes/anamenu");
            Time.timeScale = 1.0f;
        }
    }


    public GameObject boru;
    // Start is called before the first frame update
    

    // Update is called once per frame

    void boruekle()
    {
        GameObject yeniboru = Instantiate(boru);
    }

    public void skorarttir(int deger)
    {
        skor += deger;
        skortxt.text = skor.ToString();
        sesdosya.PlayOneShot(pointses);
        sonskor.text = skor.ToString();       

    }

    public void yildizhesap()
    {
        if (skor <=100)
        {
            yildiz.SetActive(true);
        }
        else if(skor <=500)
        {
            yildiz1.SetActive(true);
        }
        else if (skor <= 1000)
        {
            yildiz2.SetActive(true);
        }
        else if (skor >= 1001)
        {
            yildiz3.SetActive(true);
        }
        else
        {
            yildiz3.SetActive(true);
        }
    }


    void Update()
    {
        if (skor > enyuksek)
        {
            enyuksek = skor;
            PlayerPrefs.SetInt("enyuksekt", enyuksek);
            enyuksekskor.text = enyuksek.ToString();
        }
        else
        {
            enyuksek = PlayerPrefs.GetInt("enyuksekt");
            enyuksekskor.text = enyuksek.ToString();
        }

    }
}
