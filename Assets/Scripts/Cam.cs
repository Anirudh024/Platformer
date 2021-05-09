using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject some;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        count = some.GetComponent<Player>().Get();
    }

    // Update is called once per frame
    void Update()
    {   
        
         if(count == 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }
         else if(count == 1)
        {
            transform.position = new Vector3(16, 0, -10);
        }
        else if (count == 2)
        {
            transform.position = new Vector3(32, 0, -10);
        }
        else if (count == 3)
        {
            transform.position = new Vector3(50, 0, -10);
        }
        else if(count == 4)
        {
            transform.position = new Vector3(0,0,-10);
        }
    }
    public void move()
    {
        count++;
    }
}
