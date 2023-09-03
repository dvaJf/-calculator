using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Ravno : MonoBehaviour
{
    private double one;
    private double two;
    [SerializeField] TextMeshProUGUI display;
    [SerializeField] Text TEST;
    private Stack<string> znaki = new();
    private Stack<double> chisla = new();
    private string TextAnaliz;
    private string AnalizSymbol;
    private string AnalizSymbolS;
    public void ButonRavno()
    {
        string TextProverka = ButonS.IkranText;
        string Varajenie = TextProverka;

        bool ProverkaLastSimvol = TextProverka.Substring(TextProverka.Length - 1) != " " && TextProverka.Substring(TextProverka.Length - 1)
        != "^" && TextProverka.Substring(TextProverka.Length - 1) != "-" && TextProverka.Substring(TextProverka.Length - 1)
        != "+" && TextProverka.Substring(TextProverka.Length - 1) != "×" && TextProverka.Substring(TextProverka.Length - 1)
        != "÷" && TextProverka.Substring(TextProverka.Length - 1) != "," && TextProverka.Substring(TextProverka.Length - 1)
        != "√" && TextProverka.Substring(TextProverka.Length - 1) != "!";

        bool ProverkaNaZnaki = TextProverka.Contains("÷") || TextProverka.Contains("×") || TextProverka.Contains("+")
        || TextProverka.Contains("-") || TextProverka.Contains("^") || TextProverka.Contains("%")
        || TextProverka.Contains("√") || TextProverka.Contains("!");

        if (ProverkaLastSimvol && ProverkaNaZnaki)
        {
            Analiz();
            Convrt();
            while (znaki.Count > 0)
            {
                Mathe();
            }
            ButonS.IkranText = " " + Convert.ToString(chisla.Peek());
            display.text = ButonS.IkranText;
            string Rezeltat = ButonS.IkranText;
            string HullVaraj = Environment.NewLine + DateTime.Now.ToString("dd MMMM") + Environment.NewLine + Varajenie + " =" + Rezeltat + Environment.NewLine + PlayerPrefs.GetString("histori");
            PlayerPrefs.SetString("histori", HullVaraj);
            PlayerPrefs.SetString("histori", HullVaraj);
            Acv();
        }
    }

    public void ButonAc()
    {
        Acv();
        TEST.text = "";
        display.text = " ";
        ButonS.IkranText = " ";
    }

    private void Acv()
    {
        chisla.Clear();
        znaki.Clear();
        one = 0;
        two = 0;
        TextAnaliz = "";
        AnalizSymbol = "";
        AnalizSymbolS = "";

    }

    private int PoradokDestvi(string z)
    {
        if (z == "+" || z == "-")
        { return 1; }
        if (z == "×" || z == "÷")
        { return 2; }
        if (z == "^" || z == "√" || z == "!" || z == "%")
        { return 3; }
        if (z == "(")
        { return 0; }
        return 0;
    }
    private void Analiz()
    {
        TextAnaliz = ButonS.IkranText;
        TextAnaliz = TextAnaliz.Remove(0, 1);
        AnalizSymbol = TextAnaliz.Substring(0, 1);

        if (AnalizSymbol == "-")
        {
            AnalizSymbolS = AnalizSymbolS + AnalizSymbol;
            TextAnaliz = TextAnaliz.Remove(0, 1);
        }

        while (TextAnaliz.Length > 0)
        {
            AnalizSymbol = TextAnaliz.Substring(0, 1);
            TextAnaliz = TextAnaliz.Remove(0, 1);

            if (AnalizSymbol == "0" || AnalizSymbol == "1" || AnalizSymbol == "2" || AnalizSymbol == "3" || AnalizSymbol == "4" || AnalizSymbol == "5" ||
                AnalizSymbol == "6" || AnalizSymbol == "7" || AnalizSymbol == "8" || AnalizSymbol == "9" || AnalizSymbol == ",")
            {
                AnalizSymbolS = AnalizSymbolS + AnalizSymbol;
            }

            if (AnalizSymbol == "π")
            {
                AnalizSymbolS = AnalizSymbolS + "3,1415926535897931";
            }

            if (AnalizSymbol == "(")
            {

                Convrt();

                znaki.Push("(");
                AnalizSymbolS = "";
            }

            if (AnalizSymbol == ")")
            {

                Convrt();

                while (znaki.Peek() != "(")
                {
                    Mathe();
                }
                znaki.Pop();
                AnalizSymbolS = "";
            }

            if (AnalizSymbol == "+")
            {

                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }

                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }

                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "-")
            {
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {
                    Convrt();


                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "÷")
            {

                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "×")
            {
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();


                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "%")
            {


                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {


                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "^")
            {

                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {


                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "√")
            {

                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {

                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {


                    Convrt();

                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

            if (AnalizSymbol == "!")
            {

                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) <= PoradokDestvi(znaki.Peek()))
                {

                    Convrt();

                    Mathe();
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count == 0)
                {
                    if (AnalizSymbolS != "")
                    {
                        Convrt();
                    }
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
                if (znaki.Count != 0 && PoradokDestvi(AnalizSymbol) > PoradokDestvi(znaki.Peek()))
                {

                    if (AnalizSymbolS != "")
                    {
                        Convrt();
                    }
                    znaki.Push(AnalizSymbol);
                    AnalizSymbolS = "";
                }
            }

        }
    }

    private void Convrt()
    {
        if (AnalizSymbolS != "")
        {
            chisla.Push(Convert.ToDouble(AnalizSymbolS));
        }
    }

    private void Mathe()
    {
        double rezel;
        string zna = znaki.Pop();

        if (zna == "×")
        {
            two = chisla.Pop();
            one = chisla.Pop();
            rezel = one * two;
            chisla.Push(rezel);
        }

        if (zna == "+")
        {
            two = chisla.Pop();
            one = chisla.Pop();
            rezel = one + two;
            chisla.Push(rezel);
        }

        if (zna == "÷")
        {
            one = chisla.Pop();
            two = chisla.Pop();
            if (one != 0)
            {
                rezel = two / one;
                chisla.Push(rezel);
            }
            else
                TEST.text = "ошибка";
        }

        if (zna == "-")
        {
            one = chisla.Pop();
            two = chisla.Pop();
            rezel = two - one;
            chisla.Push(rezel);
        }

        if (zna == "!")
        {
            one = chisla.Pop();
            rezel = Factorial(one);
            chisla.Push(rezel);
        }
        if (zna == "%")
        {
            one = chisla.Pop();
            rezel = one / 100;
            chisla.Push(rezel);
        }

        if (zna == "^")
        {
            two = chisla.Pop();
            one = chisla.Pop();
            rezel = Math.Pow(one, two);
            chisla.Push(rezel);
        }

        if (zna == "√")
        {
            one = chisla.Pop();
            rezel = Math.Sqrt(one);
            chisla.Push(rezel);
        }
    }
    private double Factorial(double n)
    {
        string OneText = Convert.ToString(one);
        if (!OneText.Contains(","))
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
        return 0;
    }
}
