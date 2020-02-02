using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (MyVariableStorage.selected == false)
            {
                MyVariableStorage.selection = gameObject.name;
            }
            MyVariableStorage.OldSelection = MyVariableStorage.CurrentSelection;
            MyVariableStorage.CurrentSelection = gameObject.name;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (MyVariableStorage.selected == false)
        {
            if (MyVariableStorage.selection == gameObject.name)
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }
            else
            {
                GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1);
            }
            if (Input.GetKeyDown("enter") | Input.GetKeyDown("return"))
            {
                MyVariableStorage.selected = true;
            }
        }

    }
}
