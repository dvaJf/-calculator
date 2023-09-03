
using UnityEngine;

public class DopPanel : MonoBehaviour
{
    [SerializeField] GameObject vik;
    [SerializeField] GameObject vk;
    [SerializeField] GameObject stepen;
    [SerializeField] GameObject procent;
    [SerializeField] GameObject ckobci;
    [SerializeField] GameObject ckobci2;
    [SerializeField] GameObject delenei;
    [SerializeField] GameObject KOren;
    [SerializeField] GameObject hactorial;
    [SerializeField] GameObject pu;

    public void vkl()
    {
        vk.SetActive(false);
        vik.SetActive(true);
        procent.SetActive(true);
        stepen.SetActive(true);
        pu.SetActive(true);
        KOren.SetActive(true);
        hactorial.SetActive(true);
        delenei.SetActive(false);
        ckobci.SetActive(false);
        ckobci2.SetActive(false);
        delenei.SetActive(false);
    }
    public void vkul()
    {
        vk.SetActive(true);
        vik.SetActive(false);
        stepen.SetActive(false);
        KOren.SetActive(false);
        pu.SetActive(false);
        hactorial.SetActive(false);
        procent.SetActive(false);
        ckobci.SetActive(true);
        ckobci2.SetActive(true);
        delenei.SetActive(true);
    }
}
