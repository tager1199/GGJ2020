using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHandling : MonoBehaviour
{
    public GameObject StartText;
    public GameObject USText;
    public GameObject UKText;
    public GameObject FranceText;
    public GameObject IndiaText;
    public GameObject ChinaText;
    public GameObject NKText;
    public GameObject PakText;
    public GameObject RusText;


    // Start is called before the first frame update
    void Start()
    {
        StartText = GameObject.Find("StartText");
        USText = GameObject.Find("AmericaText");
        UKText = GameObject.Find("UKText");
        FranceText = GameObject.Find("FranceText");
        IndiaText = GameObject.Find("IndiaText");
        ChinaText = GameObject.Find("ChinaText");
        NKText = GameObject.Find("NKText");
        PakText = GameObject.Find("PakText");
        RusText = GameObject.Find("RusText");
}

    // Update is called once per frame
    void Update()
    {
        USText.SetActive(false);
        UKText.SetActive(false);
        FranceText.SetActive(false);
        IndiaText.SetActive(false);
        ChinaText.SetActive(false);
        NKText.SetActive(false);
        PakText.SetActive(false);
        RusText.SetActive(false);
        string country = MyVariableStorage.selection;
        if (MyVariableStorage.selected == true)
        {
            StartText.SetActive(false);
        }
        else
        {
            if (country == "UnitedStates")
            {
                USText.SetActive(true);
            }
            else if (country == "UnitedKingdom")
            {
                UKText.SetActive(true);
            }
            else if (country == "Russia")
            {
                RusText.SetActive(true);
            }
            else if (country == "China")
            {
                ChinaText.SetActive(true);
            }
            else if (country == "France")
            {
                FranceText.SetActive(true);
            }
            else if (country == "India")
            {
                IndiaText.SetActive(true);
            }
            else if (country == "NorthKorea")
            {
                NKText.SetActive(true);
            }
            else if (country == "Pakistan")
            {
                PakText.SetActive(true);
            }
        }
    }
}
