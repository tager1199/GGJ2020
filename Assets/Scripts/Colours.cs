using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyVariableStorage
{
    public static bool selected = false;
    public static string selection = "";
    public static string OldSelection = "";
    public static string CurrentSelection = "";
    public static int  RelUpdate1 = 1;
    public static int SecretRelUpdate1 = 1;
    public static int RelUpdate2 = 1;
    public static int SecretRelUpdate2 = 1;
    public static int RelUpdate3 = 1;
    public static int SecretRelUpdate3 = 1;
}

public class Colours : MonoBehaviour
{
    // Start is called before the first frame update
    public float relationship = 0;
    public float secretRelationship = 0;
    public bool first = false;
    public Color lerpedColor = new Color(1, 1, 1);
    public static Colours Instance;
    void Start()
    {
        GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        int relCount = 0;
        if (MyVariableStorage.selected == true && MyVariableStorage.selection != gameObject.name)
        {
            if (first == false)
            {
                if (MyVariableStorage.selection == "UnitedKingdom" | MyVariableStorage.selection == "France" | MyVariableStorage.selection == "India" | MyVariableStorage.selection == "UnitedStates")
                {
                    if (gameObject.name == "UnitedStates" | gameObject.name == "France" | gameObject.name == "India" | gameObject.name == "UnitedKingdom")
                    {
                        relationship = 5;
                        secretRelationship = 4;
                    }
                    else if (gameObject.name == "Pakistan")
                    {
                        relationship = 3;
                        secretRelationship = 1;
                    }
                    else if (gameObject.name == "Russia" | gameObject.name == "China")
                    {
                        relationship = 0;
                        secretRelationship = -2;
                    }
                    else
                    {
                        relationship = -3;
                        secretRelationship = -5;
                    }
                }
                else if (MyVariableStorage.selection == "Pakistan")
                {
                    if (gameObject.name == "India")
                    {
                        relationship = 5;
                        secretRelationship = 4;
                    }
                    else if (gameObject.name == "UnitedStates" | gameObject.name == "France" | gameObject.name == "UnitedKingdom")
                    {
                        relationship = 2;
                        secretRelationship = 1;
                    }
                    else if (gameObject.name == "Russia" | gameObject.name == "China")
                    {
                        relationship = 0;
                        secretRelationship = -2;
                    }
                    else
                    {
                        relationship = -3;
                        secretRelationship = -5;
                    }
                }
                else if (MyVariableStorage.selection == "Russia" | MyVariableStorage.selection == "China")
                {
                    if (gameObject.name == "Russia" | gameObject.name == "China")
                    {
                        relationship = 3;
                        secretRelationship = 3;
                    }
                    else if (gameObject.name == "UnitedStates" | gameObject.name == "France" | gameObject.name == "India" | gameObject.name == "UnitedKingdom" | gameObject.name == "Pakistan")
                    {
                        relationship = 0;
                        secretRelationship = -2;
                    }
                    else
                    {
                        relationship = -3;
                        secretRelationship = -5;
                    }
                }
                else
                {
                    relationship = -5;
                    secretRelationship = -6;
                }


                first = true;
            }
            Color NewColour;
            if (relationship > 0)
            {
                NewColour = Color.Lerp(lerpedColor, Color.green, relationship / 10);
                relCount += 1;
            }
            else if (relationship < 0)
            {
                NewColour = Color.Lerp(lerpedColor, Color.red, relationship / -10);
            }
            else
            {
                NewColour = lerpedColor;
            }
            if (gameObject.name == MyVariableStorage.CurrentSelection)
            {
                NewColour = lerpedColor;
            }
            GetComponent<Renderer>().material.color = NewColour;
            if (relCount > 4)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
    public void ChangeRelationship(int choice)
    {
        switch (choice)
        {
            case 1:
                if (gameObject.name == MyVariableStorage.CurrentSelection)
                {
                    relationship += MyVariableStorage.RelUpdate1;
                    secretRelationship += MyVariableStorage.SecretRelUpdate1;
                }
                break;
            case 2:
                if (gameObject.name == MyVariableStorage.CurrentSelection)
                {
                    relationship += MyVariableStorage.RelUpdate2;
                    secretRelationship += MyVariableStorage.SecretRelUpdate2;
                }
                break;
            case 3:
                if (gameObject.name == MyVariableStorage.CurrentSelection)
                {
                    relationship += MyVariableStorage.RelUpdate3;
                    secretRelationship += MyVariableStorage.SecretRelUpdate3;
                }
                break;
        }

    }
}
