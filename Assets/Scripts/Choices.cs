using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Choices : MonoBehaviour
{
    public Dictionary<int, string[]> Allies = new Dictionary<int, string[]>();
    public Dictionary<int, string[]> Other = new Dictionary<int, string[]>();
    public Dictionary<int, string[]> NK = new Dictionary<int, string[]>();
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public int Opt1Rel;
    public int Opt2Rel;
    public int Opt3Rel;
    public static Choices Instance;
    bool first = false;
    // Start is called before the first frame update
    void Start()
    {

        Button1 = GameObject.Find("Button1");
        Button2 = GameObject.Find("Button2");
        Button3 = GameObject.Find("Button3");
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
        Allies.Add(0, new string[2] { "2", "Make a trade deal" });
        Allies.Add(1, new string[2] { "2", "Give them free stuff" });
        Allies.Add(2, new string[2] { "1", "Enable free movement" });
        Allies.Add(3, new string[2] { "-12", "Go to war" });
        Allies.Add(4, new string[2] { "-20", "Nuke them" });

        Other.Add(0, new string[2] { "1", "Make a trade deal" });
        Other.Add(1, new string[2] { "-3", "Invade them" });
        Other.Add(2, new string[2] { "2", "Give them Aidl" });

        NK.Add(0, new string[2] { "-20", "Nuke them" });
        NK.Add(1, new string[2] { "-20", "Nuke them" });
        NK.Add(2, new string[2] { "5", "Nuke them" });
        NK.Add(3, new string[2] { "5", "Nuke them" });
        NK.Add(4, new string[2] { "5", "Nuke them" });
        NK.Add(5, new string[2] { "5", "Surrender" });


    }

    // Update is called once per frame
    void Update()
    {        
        if (MyVariableStorage.selected == true && (MyVariableStorage.OldSelection != MyVariableStorage.CurrentSelection || first == false))
        {
            MyVariableStorage.OldSelection = MyVariableStorage.CurrentSelection;
            first = true;
            Button1.SetActive(true);
            Button2.SetActive(true);
            Button3.SetActive(true);
            List<int> uniqueNumbers = new List<int>();
            string selection = MyVariableStorage.CurrentSelection;
            List<int> randList = new List<int>();
            int MaxNum;
            Dictionary<int, string[]> UseList;
            if (selection == "UnitedKingdom" | selection == "UnitedStates" | selection == "France" | selection == "India")
            {
                UseList = Allies;
                MaxNum = Allies.Count;
                for (int i = 0; i < MaxNum+1; i++)
                {
                    uniqueNumbers.Add(i);
                }
                for (int i = 0; i < 3; i++)
                {
                    int ranNum = uniqueNumbers[Random.Range(0, uniqueNumbers.Count)];
                    randList.Add(ranNum);
                    uniqueNumbers.Remove(ranNum);
                }
                Button1.GetComponentInChildren<Text>().text = UseList[randList[0]][1];
                Button2.GetComponentInChildren<Text>().text = UseList[randList[1]][1];
                Button3.GetComponentInChildren<Text>().text = UseList[randList[2]][1];
                MyVariableStorage.RelUpdate1 = int.Parse(UseList[randList[0]][0]);
                MyVariableStorage.RelUpdate2 = int.Parse(UseList[randList[1]][0]);
                MyVariableStorage.RelUpdate3 = int.Parse(UseList[randList[2]][0]);
                MyVariableStorage.SecretRelUpdate1 = int.Parse(UseList[randList[0]][0]);
                MyVariableStorage.SecretRelUpdate2 = int.Parse(UseList[randList[1]][0]);
                MyVariableStorage.SecretRelUpdate3 = int.Parse(UseList[randList[2]][0]);
            }
            else if (selection == "NorthKorea")
            {
                UseList = NK;
                MaxNum = NK.Count;
                for (int i = 0; i < MaxNum+1; i++)
                {
                    uniqueNumbers.Add(i);
                }
                for (int i = 0; i < 3; i++)
                {
                    int ranNum = uniqueNumbers[Random.Range(0, uniqueNumbers.Count)];
                    randList.Add(ranNum);
                    uniqueNumbers.Remove(ranNum);
                }
                    Button1.GetComponentInChildren<Text>().text = UseList[randList[0]][1];
                    Button2.GetComponentInChildren<Text>().text = UseList[randList[1]][1];
                    Button3.GetComponentInChildren<Text>().text = UseList[randList[2]][1];
                    MyVariableStorage.RelUpdate1 = int.Parse(UseList[randList[0]][0]);
                    MyVariableStorage.RelUpdate2 = int.Parse(UseList[randList[1]][0]);
                    MyVariableStorage.RelUpdate3 = int.Parse(UseList[randList[2]][0]);
                    MyVariableStorage.SecretRelUpdate1 = int.Parse(UseList[randList[0]][0]);
                    MyVariableStorage.SecretRelUpdate2 = int.Parse(UseList[randList[1]][0]);
                    MyVariableStorage.SecretRelUpdate3 = int.Parse(UseList[randList[2]][0]);

            }
            else
            {
                UseList = Other;
                MaxNum = Other.Count;
                for (int i = 0; i < MaxNum+1; i++)
                {
                    uniqueNumbers.Add(i);
                }
                for (int i = 0; i < 3; i++)
                {
                    int ranNum = uniqueNumbers[Random.Range(0, uniqueNumbers.Count)];
                    randList.Add(ranNum);
                    uniqueNumbers.Remove(ranNum);
                }
                    Button1.GetComponentInChildren<Text>().text = UseList[randList[0]][1];
                    Button2.GetComponentInChildren<Text>().text = UseList[randList[1]][1];
                    Button3.GetComponentInChildren<Text>().text = UseList[randList[2]][1];
                    MyVariableStorage.RelUpdate1 = int.Parse(UseList[randList[0]][0]);
                    MyVariableStorage.RelUpdate2 = int.Parse(UseList[randList[1]][0]);
                    MyVariableStorage.RelUpdate3 = int.Parse(UseList[randList[2]][0]);
                    MyVariableStorage.SecretRelUpdate1 = int.Parse(UseList[randList[0]][0]);
                    MyVariableStorage.SecretRelUpdate2 = int.Parse(UseList[randList[1]][0]);
                    MyVariableStorage.SecretRelUpdate3 = int.Parse(UseList[randList[2]][0]);
            }

            
        }

    }
}
