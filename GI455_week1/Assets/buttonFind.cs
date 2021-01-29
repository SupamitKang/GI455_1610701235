using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonFind : MonoBehaviour
{

    List<string> nameCars = new List<string>() { "Toyota", "Honda", "Mazda", "Nissan", "BMW", };
    public List<Text> textCars = new List<Text>();
    public InputField InputFieldText;
    public GameObject output;

    // Start is called before the first frame update
    void Start()
    {
        InputFieldText.onEndEdit.AddListener(FindText);
        for(int i = 0; i <= nameCars.Count - 1; i++)
        {
            textCars[i].text = nameCars[i] .ToString();
        }
    }

    public void FindText(string textCars)
    {
        if (nameCars.Contains(InputFieldText.text))
        {
            output.GetComponent<Text>().text = "[ " + textCars + " ]" + " is found. ";
        }
        else
        {
            output.GetComponent<Text>().text = "[ " + textCars + "] " + " is not found. ";
        }
    }

}