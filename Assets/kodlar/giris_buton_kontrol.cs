using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class giris_buton_kontrol : MonoBehaviour
{
    public void basla()
    {
        SceneManager.LoadScene("oyun_sahnesi");
    }
}
