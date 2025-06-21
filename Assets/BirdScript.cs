using UnityEngine;
using System.Collections;

public class BirdScript : MonoBehaviour
{
    // wenn man variablen benutzen will muss man diese immer zuerst deklarieren (mit typ etc?)
    GameObject BirdObject; 
    Rigidbody2D BirdRigidBody2D;

    // evtl globale variablen fürs scriptänderbar: velocity

    void Start()
    {
        BirdObject = GameObject.Find("BirdObject");
        BirdRigidBody2D = BirdObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(Time.deltaTime);
            //Debug.Log(BirdObject.ToString());
            //Debug.Log(BirdObject.transform.position.y);
            //Debug.Log(BirdRigidBody2D.mass); // log something of the rigid-body-attributes of the object

            // change the vector on the y-axis so that the object moves up when pressing the spacebar --> vera bad idea..it only moves in exactly 1 frame!
            //BirdObject.transform.position = new Vector3(transform.position.x, transform.position.y + (45 * Time.deltaTime), transform.position.z);
            Debug.Log(BirdRigidBody2D.linearVelocity);
            BirdRigidBody2D.linearVelocity = new Vector2(0, 8);
        }
    }
}

// questions:
// why is a reference to the obj required?, wiso kann man nicht so eine reference machen: BirdObject = GameObject.Find("BirdObject");
