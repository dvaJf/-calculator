
using UnityEngine;

public class OffSettings : MonoBehaviour
{
    [SerializeField] GameObject Nastroiki1;
    public void Off()
    {
        Nastroiki1.SetActive(false);
    }

}