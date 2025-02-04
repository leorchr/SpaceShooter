using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Asteroid;
    public GameObject AsteroidClone1;
    public GameObject AsteroidClone2;

    void Start()
    {
        StartCoroutine("Spawn1");
        StartCoroutine("Spawn2");
    }
    IEnumerator Spawn1() // génère des astéroides sur la partie haute de l'écran
    {
        while (true)
        {
            float rand1 = Random.Range(-1.35f, -0.1f);
            AsteroidClone1 = Instantiate(Asteroid, new Vector2(4.5f, rand1), Quaternion.Euler(0, 0, 0));
            Destroy(AsteroidClone1, 10f);
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator Spawn2() // génère des astéroides sur la partie basse de l'écran
    {
        while (true)
        {
            float rand2 = Random.Range(0.1f, 1.35f);
            AsteroidClone2 = Instantiate(Asteroid, new Vector2(6f, rand2), Quaternion.Euler(0, 0, 0));
            Destroy(AsteroidClone2, 10f);
            yield return new WaitForSeconds(1);
        }
    }
}
