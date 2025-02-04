using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VictoryCondition : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene("Scenes/Victory");

    }
}
