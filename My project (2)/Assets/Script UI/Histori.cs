using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Histori : MonoBehaviour
{
    [SerializeField] GameObject DisplayHistori;
    [SerializeField] GameObject Nastroiki;
    [SerializeField] Text Histor; 
    public void VklHistori()
    {
        DisplayHistori.SetActive(true);
        Histor.text = PlayerPrefs.GetString("histori");
    }
    public void VkulHistori()
    {
        Nastroiki.SetActive(false);
        DisplayHistori.SetActive(false);
       
    }
    public void ClearHistori()
    {
        PlayerPrefs.SetString("histori", "");
        Histor.text = PlayerPrefs.GetString("histori");
    }
}
