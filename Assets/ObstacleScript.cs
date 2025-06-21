using UnityEngine;
using System.Collections;


public class ObstacleScript : MonoBehaviour
{

    GameObject ObstacleObject;
    GameObject ObstacleObjectClone;
    bool tracker = false;
    float speed = -0.01f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObstacleObject = GameObject.Find("ObstacleObject"); // object mit je einem top und bottom tree
        
    }

    // Update is called once per frame
    void Update()
    {
        ObstacleObject.transform.position = new Vector3(ObstacleObject.transform.position.x+speed, ObstacleObject.transform.position.y, ObstacleObject.transform.position.z);

        if (ObstacleObject.transform.position.x > -9 && ObstacleObject.transform.position.x < -8) {

            if (tracker == false) {
                Debug.Log(ObstacleObject.transform.position.x);
                // ein neues objectr spawnen zu beginn
                ObstacleObjectClone = Instantiate(ObstacleObject, ObstacleObject.transform.position, transform.rotation);
                tracker = true; // somit kann diese aktion nur 1mal durchgeführt werden!
            }
            
        }
        // Destroy(ObstacleObject);
    }
}
