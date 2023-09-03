
using UnityEngine;
using UnityEngine.SceneManagement;

public class PereklBlack : MonoBehaviour
{
    public void SmenaChena()
    {
        ButonS.IkranText = " ";
        int PoUmolzaniu = 0;
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("PoUmolzaniu", PoUmolzaniu);
    }
}
