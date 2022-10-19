using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fonksiyonlar : MonoBehaviour
{
    private int coinSayisi;
    public TMP_Text coinSayisiTxt;

    private int gemSayisi;
    public TMP_Text gemSayisiTxt;
   
    private int lgemSayisi;
    public TMP_Text lgemSayisiTxt;

    private void Start()
    {
        coinSayisi = PlayerPrefs.GetInt("coinSayisi");

        gemSayisi = PlayerPrefs.GetInt("gemSayisi");

        lgemSayisi = PlayerPrefs.GetInt("lgemSayisi");
    }
    private void Update()

    {
        if (PlayerPrefs.HasKey("coinSayisi"))
        {
            Debug.Log("Veri tutuluyor");
        }

        coinSayisiTxt.text = coinSayisi.ToString();

        gemSayisiTxt.text = gemSayisi.ToString();
        
        lgemSayisiTxt.text = lgemSayisi.ToString();
    }
    public void coinekle() 
    {
        coinSayisi++;
        PlayerPrefs.SetInt("coinSayisi",coinSayisi);
    }
    public void gemekle()
    {
        gemSayisi++;
        PlayerPrefs.SetInt("gemSayisi", gemSayisi);
    }
     public void lgemekle()
    {
        lgemSayisi++;
        PlayerPrefs.SetInt("lgemSayisi", lgemSayisi);
    }

    public void coinsat()
    {
        PlayerPrefs.DeleteKey("coinSayisi");
    }
    public void gemsat() 
    {
        PlayerPrefs.DeleteKey("gemSayisi");
    }
    public void lgemsat()
    {
        PlayerPrefs.DeleteKey("lgemSayisi");
    }


}
