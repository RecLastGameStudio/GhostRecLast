using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class kus : MonoBehaviour
{


    bool oyundurdu = false;

    Rigidbody2D rigi;
    public float ziplamagucu;

    public float egilmehizi;
    public GameObject panel;
    public GameObject durdurbutton;

    yonetici yonet;

    public AudioSource sesdosyasi;
    public AudioClip sescarp;
    public AudioClip jumpses;

    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();

        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        oyundurdu = true;
        durdurbutton.SetActive(false);
        panel.SetActive(true);
        Time.timeScale = 0.0f;
        sesdosyasi.PlayOneShot(sescarp);

        yonet.yildizhesap();
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {

        if (oyundurdu == false)
        {
            
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egilmehizi);
        }
        else
        {
            
        }

        

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sesdosyasi.PlayOneShot(jumpses, 3.0f) ;

            rigi.velocity = Vector2.zero;

            rigi.velocity = Vector2.up * ziplamagucu;

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 1.0f);
        }

        else
        {
           
         
                        
        }

        if (Input.GetMouseButtonDown(0))
        {
            sesdosyasi.PlayOneShot(jumpses, 3.0f) ;

            rigi.velocity = Vector2.zero;

            rigi.velocity = Vector2.up * ziplamagucu;

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 1.0f);
        }

        else
        {
           
            
        }
    }
}
