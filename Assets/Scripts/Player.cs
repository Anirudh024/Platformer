using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float horizontalMove = 0f;
    public float fallmultiplier = 2f;
    public float jumpmultiplier = 2.5f;
    public float jumpvelocity = 7f;
    private float count = -1f;
    public float delay = 0.9f;
    public int scene = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Motion();
        constrain();
        Respwan();
    }
    public void Respwan()
    {
        
        if (scene == 0)
        {
            if (transform.position.y <= -5 || transform.position.x <= -8)
            {
                transform.position = new Vector2(-6, -1);
            }
        }
        else if (scene == 1)
        {
            if (transform.position.y <= -5 || transform.position.x <= 7.55f)
            {
                transform.position = new Vector2(7.8f, 3);
            }
        }
        else if (scene == 2)
        {
            if (transform.position.y <= -5 || transform.position.x <= 23)
            {
                transform.position = new Vector2(25, 3);
            }
        }
        else if (scene == 3)
        {
            if (transform.position.y <= -5 || transform.position.x <= 41)
            {
                transform.position = new Vector2(42, 3);
            }
        }
        else if (scene == 4)
        {
            if (transform.position.y <= -5 || transform.position.x <= -8)
            {
                transform.position = new Vector2(-6, -1);
            }
        }
    }
    public void Motion()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * 2f;
        transform.Translate(Vector2.right * horizontalMove * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && Time.time > count)
        {
            count = Time.time + delay;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpvelocity;
        }

        if (GetComponent<Rigidbody2D>().velocity.y < 0)
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * Physics2D.gravity.y * (fallmultiplier - 1) * Time.deltaTime;
        }
        else if (GetComponent<Rigidbody2D>().velocity.y > 0 && !Input.GetButton("Jump"))
            GetComponent<Rigidbody2D>().velocity += Vector2.up * Physics2D.gravity * (jumpmultiplier - 1) * Time.deltaTime;

    }
    public void constrain()
    {
        if(scene == 0)
        {
            if (transform.position.x <= -8)
            {
                transform.position = new Vector2(-8, transform.position.y);
            }
        }
        else if(scene == 1)
        {
            if (transform.position.x <= 7.55f)
            {
                transform.position = new Vector2(7.55f, transform.position.y);
            }
        }
        else if (scene == 2)
        {
            if (transform.position.x <= 23)
            {
                transform.position = new Vector2(23, transform.position.y);
            }
        }
        else if (scene == 2)
        {
            if (transform.position.x <= 41)
            {
                transform.position = new Vector2(41, transform.position.y);
            }
        }

    }
    public void EnemyDamage()
    {
        if(scene == 0)
        {
            transform.position = new Vector2(-6, -1);
        }
        else if(scene == 1)
        {
            transform.position = new Vector2(7.8f, 3);
        }
        else if (scene == 2)
        {
            transform.position = new Vector2(25, 3);
        }
        else if (scene == 3)
        {
            transform.position = new Vector2(41, 3);
        }


    }
    public void Scene()
    {
        scene++;
        if(scene == 4)
        {
            Debug.Log("MENU");
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }   
public void Select1()
{
    scene = 0;
}
public void Select2()
{
    scene = 1;
}
public void Select3()
{
    scene = 2;
}
public void Select4()
{
    scene = 3;
}
public int Get()
{
    return scene;
}
}