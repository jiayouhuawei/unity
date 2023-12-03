using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // indicidual key input
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
   
        }
        //Axis input. an axis goes from -1 to 0 to 1 
        //float x = Input.GetAxis("horizontal");
        //float y = Input.GetAxis("vertical");

        //transform.Translate(new Vector3(x, y, 0f) * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        
        }


    }
}

