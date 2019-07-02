using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Transform playerPosition; 
    Direction playerDirection; 
    Animator anim; 
    public float speed = 5; 
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = this.GetComponent<Transform>(); 
        playerDirection = Direction.DOWN; 
        anim = this.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            playerDirection = Direction.RIGHT; 
            anim.SetInteger("Direction", (int)playerDirection); 
            anim.SetBool("isMoving", true);
            anim.SetTrigger("setDirection"); 
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            playerDirection = Direction.LEFT;  
            anim.SetInteger("Direction", (int)playerDirection); 
            anim.SetBool("isMoving", true);
            anim.SetTrigger("setDirection");
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            playerDirection = Direction.UP; 
            anim.SetInteger("Direction", (int)playerDirection);
            anim.SetBool("isMoving", true); 
            anim.SetTrigger("setDirection");
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            playerDirection = Direction.DOWN; 
            anim.SetInteger("Direction", (int)playerDirection); 
            anim.SetBool("isMoving", true);
            anim.SetTrigger("setDirection");
        }

        else if (Input.GetKey(KeyCode.D)){
            playerPosition.position = new Vector3(playerPosition.position.x + speed, playerPosition.position.y, playerPosition.position.z); 
            anim.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.A)){
            playerPosition.position = new Vector3(playerPosition.position.x - speed, playerPosition.position.y, playerPosition.position.z); 
            anim.SetBool("isMoving", true);
        }
        else if(Input.GetKey(KeyCode.W)){
            playerPosition.position = new Vector3(playerPosition.position.x, playerPosition.position.y + speed, playerPosition.position.z); 
            anim.SetBool("isMoving", true);
        }
        else if (Input.GetKey(KeyCode.S)){
            playerPosition.position = new Vector3(playerPosition.position.x, playerPosition.position.y - speed, playerPosition.position.z); 
            anim.SetBool("isMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.S)||Input.GetKeyUp(KeyCode.D)){
            anim.SetBool("isMoving", false);
        }
    }
}
