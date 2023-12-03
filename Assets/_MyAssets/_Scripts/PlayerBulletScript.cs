using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletScript : MonoBehaviour
{
    private float moveSpeed=20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        ////Method 1, world space check.
        //if (transform.localPosition.x >=6.8f) //when getting a certain point, destory bullet
        //{ 
        // Destroy(gameObject);   

        //}
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.x > (Screen.width + 10))
        { 
        Destroy(gameObject);    
        
        }
        


        
    }
}
