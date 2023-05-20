using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject karakter;
    
    void Update()
    {
        
        Vector3 characterPosition = karakter.transform.position;


        transform.position = new Vector3(transform.position.x, characterPosition.y+2.5f, transform.position.z);
    }
}
