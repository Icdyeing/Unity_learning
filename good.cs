using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class good : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float a = this.transform.rotation.y;
        if (a == 0)//Ïò×ó
        {
            run(1);
        }
        else
        {
            run(-1);
        }
        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if(sp.y>Screen.height)
        {
            Destroy(this.gameObject);
        }
        if (sp.y <0)
        {
            Destroy(this.gameObject);
        }

    }
    void run(int b)
    {

        float spd = -0.6f * Time.deltaTime;
        transform.Translate(spd, 0, 0);
    }
}
