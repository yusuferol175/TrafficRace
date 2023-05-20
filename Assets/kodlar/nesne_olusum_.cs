using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;


public class nesne_olusum_ : MonoBehaviour
{
    public GameObject asfalt;
    public GameObject toprak_yol;
    private float yol_pos=1.8f;
    private float araba_pos=2f;
    private float araba_2_pos = 110f;

    public GameObject araba1;
    public GameObject araba2;
    public GameObject polis;
    public GameObject kaya;
    public GameObject tir;
    public GameObject inek;

    private System.Random rnd = new System.Random();
    void Start()
    {
        for (int i = 0; i < 21; i++)
        {
            int rndm_sayi = rnd.Next(0, 3);
            float rndm_x = (float)rnd.NextDouble()*4+-2;
            if (rndm_sayi==0)
            {
                Instantiate(araba1, new Vector3(rndm_x,araba_pos,-4f), quaternion.identity);
            }
            if (rndm_sayi==1)
            {
                Instantiate(araba2, new Vector3(rndm_x,araba_pos,-4f), quaternion.identity);
            }
            if (rndm_sayi==2)
            {
                Instantiate(polis, new Vector3(rndm_x,araba_pos,-4f), quaternion.identity);
            }
            araba_pos = araba_pos + 5f;
        }
        for (int i = 0; i < 17; i++)
        {
            int rndm_sayi = rnd.Next(0, 3);
            float rndm_x = (float)rnd.NextDouble()*4+-2;
            if (rndm_sayi==0)
            {
                Instantiate(kaya, new Vector3(rndm_x,araba_2_pos,-4f), quaternion.identity);
            }
            if (rndm_sayi==1)
            {
                Instantiate(tir, new Vector3(rndm_x,araba_2_pos,-4f), quaternion.identity);
            }
            if (rndm_sayi==2)
            {
                Instantiate(inek, new Vector3(0f,araba_2_pos,-4f), quaternion.identity);
            }
            araba_2_pos = araba_2_pos + 6f;
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(asfalt, new Vector3(-0.862663f,yol_pos,0f), quaternion.identity);
            
            
            yol_pos = yol_pos +11.2f;
            
        }
        for (int i = 0; i < 10; i++)
        {
            Instantiate(toprak_yol, new Vector3(-0.862663f,yol_pos,0f), quaternion.identity);
            yol_pos = yol_pos +11.2f;
        }
        
    }

    
}
