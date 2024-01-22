using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    public InputField InputAmount;
    public Toggle toggleUS;
    public Toggle toggleJP;
    private float US_Rate = 0.74f;
    private float JP_Rate = 82.78f;

    //Arwin's Edit
    public Toggle toggleMYS;
    public Toggle toggleEU;
    public Toggle toggleKR;
    public Toggle toggleTW;
    private float MYS_Rate = 3.08f;
    private float EU_Rate = 0.63f;
    private float KR_Rate = 881.54f;
    private float TW_Rate = 20.73f;
    public float value;
    public Text finalValue;
    public int OptionToggle; // See how many toggle is on

    public void clear()
    {
        finalValue.text = "";
        InputAmount.text = "";
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
            OptionToggle++;
            finalValue.text = "$" + (value * US_Rate);
        }
        else if (toggleUS.isOn == false)
        {
            OptionToggle--;
        }
        if (toggleJP.isOn == true)
        {
            OptionToggle++;
            finalValue.text = "$" + (value * JP_Rate);
        }
        else if (toggleJP.isOn == false)
        {
            OptionToggle--;
        }




        //Arwin's Edit

        if (toggleMYS.isOn == true)
        {
            OptionToggle++;
            finalValue.text = "$" + (value * MYS_Rate);
        }
        else if(toggleMYS.isOn == false)
        {
            OptionToggle--;
        }

        if (toggleEU.isOn == true)
        {
            OptionToggle++;
            finalValue.text = "$" + (value * EU_Rate);
        }
        else if (toggleEU.isOn == false)
        {
            OptionToggle--;
        }
        
        if (toggleKR.isOn == true)
        {
            OptionToggle++;
            finalValue.text = "$" + (value * KR_Rate);
        }
        else if (toggleKR.isOn == false)
        {
            OptionToggle--;
        }

        if (toggleTW.isOn == true)
        {
            OptionToggle++;
            finalValue.text = "$" + (value * TW_Rate);
        }
        else if (toggleTW.isOn == false)
        {
            OptionToggle--;
        }
        if (OptionToggle > 1)
        {
            finalValue.text = "Please select only one option";
        }
        else if (OptionToggle == 0)
        {
            finalValue.text = "Please select an option";
        }
    }

    
}
