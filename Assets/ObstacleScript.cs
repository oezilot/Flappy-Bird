using UnityEngine;
using System.Collections;


public class ObstacleScript : MonoBehaviour
{

    // object = 
    bool tracker;
    float speed = -0.01f;
    float screenWidthWorld;

    float xInWorld(float xValue) {
        float xWorld = (Camera.main.ScreenToWorldPoint(new Vector3((xValue), Screen.height / 2, Camera.main.nearClipPlane))).x;
        return xWorld;
    }


    void Start() {
        tracker = false;

        // pixels in units umwandeln damit das spawnen unabhängig der bildschirmgrösse passieren kann!
        Debug.Log("Screen Width : " + Screen.width);
        screenWidthWorld = xInWorld(Screen.width);
        Debug.Log("World Width : " + xInWorld(Screen.width));
    }

    // Update is called once per frame
    void Update()
    {
        // object moves across the x-axis
        gameObject.transform.position = new Vector3(gameObject.transform.position.x+speed, gameObject.transform.position.y, gameObject.transform.position.z);

        if (gameObject.transform.position.x < -screenWidthWorld) {

            if (tracker == false) { // versichert dass nur einmal ein neuer baum gespawned wird!
                Debug.Log(gameObject.transform.position.x);
                // ein neues objectr spawnen zu beginn
                GameObject clone = Instantiate(gameObject, new Vector3(screenWidthWorld, gameObject.transform.position.y, gameObject.transform.position.z), transform.rotation);
                tracker = true; // somit kann diese aktion nur 1mal durchgeführt werden!
                Destroy(gameObject);
            }

        }
        // Destroy(ObstacleObject);
    }
}
