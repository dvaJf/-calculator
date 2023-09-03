using TMPro;
using UnityEngine;

public class ButonS : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI display;
    private static string TextNaIkran = " ";
    private int Ckobohki = 0;
    private bool zap = true;
    public static string IkranText
    {
        get { return TextNaIkran; }
        set { TextNaIkran = value; }
    }

    public void ButonDel()
    {
        if (TextNaIkran.Substring(TextNaIkran.Length - 1) != " ")
        {
            int dlinastroki = TextNaIkran.Length - 1;
            TextNaIkran = TextNaIkran.Remove(dlinastroki, 1);
            display.text = TextNaIkran;
        }
    }

    public void Buton1()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "1";
            display.text = TextNaIkran;
        }
    }

    public void Buton2()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "2";
            display.text = TextNaIkran;
        }
    }

    public void Buton3()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "3";
            display.text = TextNaIkran;
        }
    }

    public void Buton4()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "4";
            display.text = TextNaIkran;
        }
    }

    public void Buton5()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "5";
            display.text = TextNaIkran;
        }
    }

    public void Buton6()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "6";
            display.text = TextNaIkran;
        }
    }

    public void Buton7()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "7";
            display.text = TextNaIkran;
        }
    }

    public void Buton8()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "8";
            display.text = TextNaIkran;
        }
    }

    public void Buton9()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "9";
            display.text = TextNaIkran;
        }

    }

    public void Buton0()
    {
        if (ProverkaDlaHisel())
        {
            TextNaIkran += "0";
            display.text = TextNaIkran;
        }
    }

    public void ButonZapat()
    {
        if (ProverkaHaZnaki() && zap)
        {
            zap = false;
            TextNaIkran += ",";
            display.text = TextNaIkran;
        }
    }

    public void ButonPlus()
    {
        if (ProverkaHaZnaki())
        {
            zap = true;
            TextNaIkran += "+";
            display.text = TextNaIkran;
        }
    }
    public void ButonDelen()
    {
        if (ProverkaHaZnaki())
        {
            zap = true;
            TextNaIkran += "÷";
            display.text = TextNaIkran;
        }
    }

    public void ButonUmn()
    {
        if (ProverkaHaZnaki())
        {
            zap = true;
            TextNaIkran += "×";
            display.text = TextNaIkran;
        }
    }

    public void ButonMinus()
    {
        if (TextNaIkran == " " || ProverkaHaZnaki())
        {
            zap = true;
            TextNaIkran += "-";
            display.text = TextNaIkran;
        }
    }

    public void ButonProchent()
    {
        if (ProverkaHaZnaki() && TextNaIkran.Substring(TextNaIkran.Length - 1) != "%")
        {
            zap = true;
            TextNaIkran += "%";
            display.text = TextNaIkran;
        }
    }

    public void ButonStepen()
    {
        if (ProverkaHaZnaki())
        {
            zap = true;
            TextNaIkran += "^";
            display.text = TextNaIkran;
        }
    }

    public void ButonKoren()
    {
        if (ProverkaHaHisla() && TextNaIkran.Substring(TextNaIkran.Length - 1) != "!" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "√")
        {
            zap = true;
            TextNaIkran += "√";
            display.text = TextNaIkran;
        }
    }

    public void ButonHactorial()
    {
        if (ProverkaHaHisla() && TextNaIkran.Substring(TextNaIkran.Length - 1) != "!" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "√")
        {
            zap = true;
            TextNaIkran += "!";
            display.text = TextNaIkran;
        }
    }

    public void ButonSkodkaOtkravaet()
    {
        if (ProverkaHaHisla())
        {
            zap = true;
            TextNaIkran += "(";
            display.text = TextNaIkran;
            Ckobohki++;
        }

    }
    public void ButonSkodkaZAkravaet()
    {

        if (Ckobohki > 0)
        {
            TextNaIkran += ")";
            display.text = TextNaIkran;
            Ckobohki--;
        }
    }

    public void ButonPu()
    {
        if (ProverkaHaHisla())
        {
            TextNaIkran += "π";
            display.text = TextNaIkran;
        }
    }

    private bool ProverkaDlaHisel()
    {
        bool k;
        k = TextNaIkran != "0" && (TextNaIkran.Substring(TextNaIkran.Length - 1) != "%" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "π");
        return k;
    }

    private bool ProverkaHaZnaki()
    {
        bool a;
        a = TextNaIkran.Substring(TextNaIkran.Length - 1) != " " && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "^" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "-" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "+" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "×" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "÷" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "," && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "√" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "!";
        return a;
    }

    private bool ProverkaHaHisla()
    {
        bool b;
        b = TextNaIkran.Substring(TextNaIkran.Length - 1) != "1" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "2" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "1" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "3" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "4" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "5" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "6" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "1" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "7" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "8" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "9" && TextNaIkran.Substring(TextNaIkran.Length - 1)
        != "0" && TextNaIkran.Substring(TextNaIkran.Length - 1) != "π";
        return b;
    }

}


