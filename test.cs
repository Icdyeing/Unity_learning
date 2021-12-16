using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject ferab;
    float ts;
    public float aa = 0;
    // Start is called before the first frame update
    void Start()
    {
        float a = this.transform.rotation.y;
        aa = a;
        
        if (a == 0)//Ïò×ó
        {
            GameObject mo = Instantiate(ferab);
            mo.transform.position = transform.position + new Vector3(-1f, 0, 0);
            Vector3 righ = new Vector3(0, 0, 0);
            ferab.transform.eulerAngles = righ;
        }
        else
        {
            GameObject mo = Instantiate(ferab);
            mo.transform.position = transform.position + new Vector3(1f, 0, 0);
            Vector3 righ = new Vector3(0, 180, 0);
            ferab.transform.eulerAngles = righ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float a = this.transform.rotation.y;
        aa=a;
        ts += Time.deltaTime;
        if(ts>=10)
        {
            
            if (a == 0)//Ïò×ó
            {
                GameObject mo = Instantiate(ferab);
                mo.transform.position = transform.position + new Vector3(-1f, 0, 0);
                Vector3 righ = new Vector3(0, 0, 0);
                ferab.transform.eulerAngles = righ;
            }
            else
            {
                GameObject mo = Instantiate(ferab);
                mo.transform.position = transform.position + new Vector3(1f, 0, 0);
                Vector3 righ = new Vector3(0, 180, 0);
                ferab.transform.eulerAngles = righ;
            }
            ts = 0;
        }
    }
    
}
