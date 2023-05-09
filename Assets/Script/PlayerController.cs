using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Le joueur appuie sur la touche D");
            transform.position += new Vector3(speed*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Le joueur appuie sur la touche Q");
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Le joueur appuie sur la touche Z");
            transform.position += new Vector3(0,speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Le joueur appuie sur la touche S");
            transform.position += new Vector3(0,-speed * Time.deltaTime, 0);
        }


    }
}