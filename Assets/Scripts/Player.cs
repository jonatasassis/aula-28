using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool canMove= false;
    public static bool canJump= false;
    public Vector3 direcao;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                player.transform.position= new Vector3(player.transform.position.x, player.transform.position.y,player.transform.position.z+1);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                player.transform.position = new Vector3(player.transform.position.x-1, player.transform.position.y, player.transform.position.z);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                player.transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z);
            }
        }

        if (canJump)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y+1, player.transform.position.z);
               
            }
           
        }


    }
}
