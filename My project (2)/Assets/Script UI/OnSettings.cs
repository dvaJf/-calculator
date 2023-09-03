
using UnityEngine;

public class OnSettings : MonoBehaviour
{
    [SerializeField] GameObject Nastroiki;
    public void On()
    {
        Nastroiki.SetActive(true);
    }
}
