using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenu : MonoBehaviour
{

    public GameObject info;

    bool infomenu = false;

    public void basla_btn()
    {
        SceneManager.LoadScene("Scenes/recbird");
        Time.timeScale = 1.0f;
    }

    public void info_btn()
    {
        infomenu = !infomenu;

        if (infomenu == true)
        {
            info.SetActive(true);

        }

        else
        {
            info.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
