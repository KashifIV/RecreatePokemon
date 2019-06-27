using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Transform playerPosition; 
    public float speed = 5; 
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = this.GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)){
            playerPosition.position = new Vector3(playerPosition.position.x + speed, playerPosition.position.y, playerPosition.position.z); 
        }
        else if (Input.GetKey(KeyCode.A)){
            playerPosition.position = new Vector3(playerPosition.position.x - speed, playerPosition.position.y, playerPosition.position.z); 
        }
        else if(Input.GetKey(KeyCode.W)){
            playerPosition.position = new Vector3(playerPosition.position.x, playerPosition.position.y + speed, playerPosition.position.z); 
        }
        else if (Input.GetKey(KeyCode.S)){
             playerPosition.position = new Vector3(playerPosition.position.x, playerPosition.position.y - speed, playerPosition.position.z); 
        }

    }
}
