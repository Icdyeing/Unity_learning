using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Sprite[] sprite;
    private int m = 0;
    private float i = 0f;
    public float speed=2f;        
    public float c = 2;
    private float cz = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer render = GetComponent<SpriteRenderer>();
        render.sprite = sprite[6];
        print(Screen.width);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 righ = new Vector3(0, 0, 0);
            transform.eulerAngles = righ;
            exchan();
            run();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 left = new Vector3(0, 180, 0);
            transform.eulerAngles = left;
            exchan();
            run();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 4f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 2f;
        }


        if (Input.GetKeyDown(KeyCode.Space)&&cz<=0)
        {
            c = 0f;
            cz = 0.5f;
        }
        cz -= Time.deltaTime;
        if (c<0.5f)
        {
            jump();
            c = c + Time.deltaTime;
        }

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y < 0)
        {
            Destroy(this.gameObject);
            this.transform.position = new Vector3(-9.31f, 9.33f, 0);
        }
    }
    void jump()
    {
        SpriteRenderer render = GetComponent<SpriteRenderer>();
        render.sprite = sprite[7];
        
        transform.Translate(0, 8 * Time.deltaTime, 0);
        

        
    }
    void exchan()
    {
        i += Time.deltaTime;
        if(i>=0.5f)
        {
            SpriteRenderer render = GetComponent<SpriteRenderer>();
            render.sprite = sprite[m];
            m++;
            if (m >= 5) m = 0;
            i = 0;
        }

    }
    void run()
    {
        float spd = speed * Time.deltaTime;
       
        transform.Translate(spd, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finsh")
        {
            SpriteRenderer render = this.GetComponent<SpriteRenderer>();
            render.sprite = sprite[6];
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platforms")
        {
            SpriteRenderer render = this.GetComponent<SpriteRenderer>();
            render.sprite = sprite[6];
            
        }
        if (collision.gameObject.tag == "pl")
        {
            Destroy(collision.gameObject);
            this.transform.position = new Vector3(-9.31f, 9.33f, 0);
        }
        if (collision.gameObject.tag == "Respawn")
        {
            Destroy(collision.gameObject);
        }
    }
}
