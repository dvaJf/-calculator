
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefaultScen1 : MonoBehaviour
{
    void Start()
    {
        int chena = PlayerPrefs.GetInt("PoUmolzaniu");
        switch (chena)
        {
            case (1):
                ButonS.IkranText = " ";
                SceneManager.LoadScene(1);
                break;
        }
    }

}
