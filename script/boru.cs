using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boru : MonoBehaviour
{

    yonetici yonet;

    //4,30f ekle -4.20f sil / -1.20f ile -4
    // -5.0f sil -3.5f ekle / -3.0f ile -6.5f
    // Start is called before the first frame update
    void Start()
    {
        float rast = Random.Range(-4.0f, -1.20f);

        transform.position = new Vector3(4.30f, rast, transform.position.z);

        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -4.20f)
        {
            yonet.skorarttir(10);
            Destroy(gameObject);
        }
        transform.Translate(-3.0f*Time.deltaTime,0,0);
    }
}
