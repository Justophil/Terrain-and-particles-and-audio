using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlaneComponent : MonoBehaviour
{   
    void OnTriggerEnter(Collider other) {
        //restart level
        if(other.tag == "Player") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
