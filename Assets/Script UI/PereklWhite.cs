
using UnityEngine;
using UnityEngine.SceneManagement;

public class PereklWhite : MonoBehaviour
{
    public void SmenaChena()
    {
        ButonS.IkranText = " ";
        int PoUmolzaniu = 1;
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("PoUmolzaniu", PoUmolzaniu);
    }
}
