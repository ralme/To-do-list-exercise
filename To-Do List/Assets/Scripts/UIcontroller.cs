using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIcontroller : MonoBehaviour
{

    public void OnEnable()
    {

        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        TextField inputText = root.Q<TextField>("inputText");
        Button addButton = root.Q<Button>("addButton");
        Label outputText01 = root.Q<Label>("outputText01");
        Label outputText02 = root.Q<Label>("outputText02");
        Label outputText03 = root.Q<Label>("outputText03");
        Label outputText04 = root.Q<Label>("outputText04");
        Label outputText05 = root.Q<Label>("outputText05");
        Label outputText06 = root.Q<Label>("outputText06");
        Label outputText07 = root.Q<Label>("outputText07");
        Label outputText08 = root.Q<Label>("outputText08");
        Label outputText09 = root.Q<Label>("outputText09");
        Label outputText10 = root.Q<Label>("outputText10");

        addButton.clicked += () => SetValues(outputText01, inputText);
        addButton.clicked += () => SetValues(outputText02, inputText);
        addButton.clicked += () => SetValues(outputText03, inputText);
        addButton.clicked += () => SetValues(outputText04, inputText);
        addButton.clicked += () => SetValues(outputText05, inputText);
        addButton.clicked += () => SetValues(outputText06, inputText);
        addButton.clicked += () => SetValues(outputText07, inputText);
        addButton.clicked += () => SetValues(outputText08, inputText);
        addButton.clicked += () => SetValues(outputText09, inputText);
        addButton.clicked += () => SetValues(outputText10, inputText);

    }

    public void SetValues(Label t2, TextField t1)
    {
        t2.text = t1.value;
    }

}