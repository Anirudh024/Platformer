using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public GameObject other;
    public void Level1()
    {
        other.GetComponent<Player>().Select1();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Level2()
    {
        other.GetComponent<Player>().Select2();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Level3()
    {
        other.GetComponent<Player>().Select3();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Level4()
    {
        other.GetComponent<Player>().Select4();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
