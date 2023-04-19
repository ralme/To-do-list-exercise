using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;

public class UIcontroller : MonoBehaviour
{

    public void OnEnable()
    {

        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        TextField inputText = root.Q<TextField>("inputText");
        Button addButton = root.Q<Button>("addButton");
        VisualElement toggleContainer = root.Q<VisualElement>("toggleContainer");
        VisualElement labelContainer = root.Q<VisualElement>("labelContainer");
        VisualElement buttonContainer = root.Q<VisualElement>("buttonContainer");
        //StyleSheet Stylesheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Stylesheet.uss");
        //int count = 0;

        //if (count < 10)
        //{
            addButton.clicked += () =>
            {
                Toggle listToggle = new Toggle();

                Label listLabel = new Label();

                Button deleteButton = new Button();
                deleteButton.text = "Delete";
                //deleteButton.styleSheets.Add(Stylesheet);

                toggleContainer.Add(listToggle);
                labelContainer.Add(listLabel);
                buttonContainer.Add(deleteButton);
                SetValues(listLabel, inputText);
                //count++;

                deleteButton.clicked += () =>
                {
                    toggleContainer.Remove(listToggle);
                    labelContainer.Remove(listLabel);
                    buttonContainer.Remove(deleteButton);
                    //count--;
                };
            };
        //}

    }

    public void SetValues(Label t2, TextField t1)
    {
        t2.text = t1.value;
        t1.value = "";
    }

}