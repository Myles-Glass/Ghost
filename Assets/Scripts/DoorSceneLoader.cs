using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSceneLoader : MonoBehaviour
{

    bool enter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enter == true)
        {
            if (Input.GetKeyDown("f"))
            {
                SceneManager.LoadScene("BuildingOne", LoadSceneMode.Single);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            (enter) = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            (enter) = true;
        }
    }
}
