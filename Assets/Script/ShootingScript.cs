using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    
    public GameObject particleSystemToSpawn;
    public Transform spawnPoint;
    public AudioSource source;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //TODO Shooting logic
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0));
            RaycastHit hit;
            // Happens when you shoot but not if you hit
            // gun shots
            // particles
            source.Play();
            Instantiate(particleSystemToSpawn, spawnPoint.position, spawnPoint.rotation);
            if(Physics.Raycast(ray,out hit)) {
                // Happens when the ray hits something
                // bullet hits the wall
                // hit zombie
                if(hit.collider.tag == "Target") {
                    TargetComponent tc = hit.collider.gameObject.GetComponent<TargetComponent>();
                    if(tc != null) {
                        tc.ProcessHit();
                    }
                }
            }
        }
        
    }
}
