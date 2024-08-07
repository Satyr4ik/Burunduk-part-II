using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed; 
    public float distance;
    private bool moovingRight = true;
    public Transform groundDetection;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false)
        {
            if(moovingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moovingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moovingRight = true;
            }
            
        }
    }
}
