using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulut : MonoBehaviour
{

    // -5.0f 5.0f / -2.0f 4,50f 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -5.0f)
        {
            float ydegeri = Random.Range(-2.0f, 4.30f);

            transform.position = new Vector3(5.0f,ydegeri,transform.position.z);

        }

        transform.Translate(-1.0f * Time.deltaTime, 0, 0);
    }
}
