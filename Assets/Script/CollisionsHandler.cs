using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionsHandler : MonoBehaviour
{
    public int heart = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log("Aie");
            heart = heart - 1;
            if (heart == 1)
            {
                heart2.GetComponent<Animator>().SetTrigger("hurt");
            }

            if (heart == 2)
            {
                heart3.GetComponent<Animator>().SetTrigger("hurt");
            }

            if (heart == 0)
            {
                heart1.GetComponent<Animator>().SetTrigger("hurt");
                SceneManager.LoadScene("Scenes/GameOver");
            }
        }
    }

}
