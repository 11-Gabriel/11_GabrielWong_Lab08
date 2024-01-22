using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public InputField InputAmount;
    public Toggle toggleUS;
    public Toggle toggleJP;
    public float US_Rate = 0.74f;
    public float JP_Rate = 82.78f;
    public float value;
    public Text finalValue;

    public void clear()
    {
        finalValue.text = "";
    }

    public void Convert()
    {
        if (InputAmount.text == "")
        {
            finalValue.text = "Please enter a number";
            return;
        }
        value = float.Parse(InputAmount.text);

        if (toggleUS.isOn == true)
        {
            finalValue.text = "$" + (value * US_Rate);
        }
        else if(toggleJP.isOn == true)
        {
            finalValue.text = "$" + (value * JP_Rate);
        }
        if(toggleJP.isOn == true && toggleUS.isOn == true)
        {
            finalValue.text = "Please select only one option";
        }
        else if (toggleJP.isOn == false && toggleUS.isOn == false)
        {
            finalValue.text = "Please select an option";
        }
    }

    
}
