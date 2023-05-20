using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inek_ : MonoBehaviour
{
    public float speed = -1.0f;

    
    public Vector3 direction = Vector3.right;

    
    public float distance = 2f;

    
    private Vector3 startPosition;

    
    private bool isMoving = true;

    void Start()
    {
        
        startPosition = transform.position;
    }

    void Update()
    {
        
        if (isMoving)
        {
            
            Vector3 newPosition = transform.position + direction * speed * Time.deltaTime;

            
            if (Vector3.Distance(startPosition, newPosition) >= distance)
            {
                direction = -direction;
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }

            
            transform.position = newPosition;
        }
    }
}
