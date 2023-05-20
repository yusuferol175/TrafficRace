using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class araba_ : MonoBehaviour
{
    public TMP_Text can_t;
    public AudioClip kaza_ses;
    public AudioClip bip_ses;
    public AudioSource ses;
    public AudioSource arka_muzik;
    public GameObject biten_anim;
    public GameObject giris_t;

    public void yenile()
    {
        SceneManager.LoadScene("oyun_sahnesi");
    }
    public void giris_don()
    {
        SceneManager.LoadScene("giris");
    }
    private void giris_t_()
    {
        giris_t.SetActive(true);
    }
    private void anim_()
    {
        Invoke("giris_t_",1.5f);
        ses.PlayOneShot(bip_ses);
        arka_muzik.Stop();
        biten_anim.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag=="dusman")
        {
            ses.PlayOneShot(kaza_ses);
            can--;
            Handheld.Vibrate();
            if (can==0)
            {
                SceneManager.LoadScene("oyun_bitti");
                can_t.GetComponent<TMP_Text>().text = "Can x " + can.ToString();
            }
            
            can_t.GetComponent<TMP_Text>().text = "Can x " + can.ToString();
            Destroy(col.gameObject);
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            Invoke("renk_geri_al",0.5f);
        }
        if(col.gameObject.tag=="bitis")
        {
            Invoke("anim_",0.5f);
            bitti = true;
            sag_but.gameObject.SetActive(false);
            sol_but.gameObject.SetActive(false);
            gameObject.GetComponent<AudioSource>().Stop();
        }
    }

    private void renk_geri_al()
    {
        gameObject.GetComponent<SpriteRenderer>().color=Color.white;
    }
    private int can=3;
    private bool hareket;
    public float hareket_hizi;

    public Button sag_but;
    public Button sol_but;
    
    
    public void move_start(bool sol_da_m)
    {
        if (sol_da_m)
        {
            if (hareket_hizi>0)
            {
                hareket_hizi *= -1;
            }
            
        }
        else
        {
            if (hareket_hizi<0)
            {
                hareket_hizi *= -1;
            }
            
        }

        hareket = true;
    }
    public void move_stop()
    {
        hareket = false;

    }
    void Start()
    {
        can_t.GetComponent<TMP_Text>().text = "Can x " + can.ToString();
        bitti = false;
        biten_anim.SetActive(false);
        giris_t.SetActive(false);
    }

    private bool bitti = false;
    void Update()
    {
        if (bitti==false)
        {
            if (gameObject.GetComponent<AudioSource>().isPlaying==false)
            {
                gameObject.GetComponent<AudioSource>().Play();
            }
            
            transform.position += new Vector3(0f, 1, 0) * Time.deltaTime * 3;
        }
        
        if (hareket)
        {
            transform.position += new Vector3(hareket_hizi, 0f, 0f) * Time.deltaTime * 4;
        }
    }
}
