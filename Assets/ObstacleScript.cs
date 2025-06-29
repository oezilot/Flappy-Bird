using UnityEngine;
using System.Collections;


public class ObstacleScript : MonoBehaviour
{

    // object = 
    bool tracker;
    float speed = -0.01f;
    float xInWorld;

  
    void Start() {
        tracker = false;

        // pixels in units umwandeln damit das spawnen unabhängig der bildschirmgrösse passieren kann!
        Debug.Log("Screen Width : " + Screen.width);
        xInWorld = (Camera.main.ScreenToWorldPoint(new Vector3((Screen.width), Screen.height / 2, Camera.main.nearClipPlane))).x;
        Debug.Log("World Width : " + xInWorld);
    }

    // Update is called once per frame
    void Update()
    {
        // object moves across the x-axis
        gameObject.transform.position = new Vector3(gameObject.transform.position.x+speed, gameObject.transform.position.y, gameObject.transform.position.z);

        if (gameObject.transform.position.x < -xInWorld) {

            if (tracker == false) { // versichert dass nur einmal ein neuer baum gespawned wird!
                Debug.Log(gameObject.transform.position.x);
                // ein neues objectr spawnen zu beginn
                GameObject clone = Instantiate(gameObject, new Vector3(xInWorld, gameObject.transform.position.y, gameObject.transform.position.z), transform.rotation);
                tracker = true; // somit kann diese aktion nur 1mal durchgeführt werden!
                Destroy(gameObject);
            }

        }
        // Destroy(ObstacleObject);
    }
}
