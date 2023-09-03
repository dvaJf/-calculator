
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefaultScen0 : MonoBehaviour
{
    void Start()
    {
        int chena = PlayerPrefs.GetInt("PoUmolzaniu");
        switch (chena)
        {
            case (0):
                ButonS.IkranText = " ";
                SceneManager.LoadScene(0);
                break;
        }
    }


}
