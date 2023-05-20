using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buton_kontrol_olum : MonoBehaviour
{
    public void yenile()
    {
        SceneManager.LoadScene("oyun_sahnesi");
    }

    public void giris_don()
    {
        SceneManager.LoadScene("giris");
    }
}
