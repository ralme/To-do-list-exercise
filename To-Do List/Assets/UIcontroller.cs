using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UIcontroller : MonoBehaviour
{

    public void OnEnable(){
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        TextField Textinput01= root.Q<TextField>("Textinput01");
        Button Buttoninput01= root.Q<Button>("Buttoninput01");
        Label Output01= root.Q<Label>("Output01");
        Buttoninput01.clicked += () => setValues(Output01,Textinput01);


      
    }


    public void setValues(Label t2, TextField t1)
    {       t2.text = t1.value;}

}
