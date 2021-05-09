using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
            other.transform.GetComponent<Player>().Scene();
            a = GameObject.FindGameObjectWithTag("MainCamera");
            a.transform.GetComponent<Cam>().move();
        }
    }
}
