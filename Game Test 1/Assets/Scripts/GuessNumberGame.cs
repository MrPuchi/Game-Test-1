using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GuessNumberGame : MonoBehaviour {

    public InputField Input;
    public Text InfoText;
    private int guessnumber;
    private int userguess;
    private Text PH;

    // Use this for initialization
    void Start()
    {
        guessnumber = Random.Range(0, 100);
        Input.ActivateInputField();
        PH = Input.placeholder.GetComponent<Text>();

    }
	public void checkguess()
    {
        PH.text = "Keep trying!";
        if (Input.text == "")
        {
            InfoText.text = "You have to enter a number";
            Input.text = "";
            Input.ActivateInputField();
            return;
        }
        userguess = int.Parse(Input.text);

        if (userguess == guessnumber)
        {
            InfoText.text = "You are Wizard!! The number is " + guessnumber;
            return;
        }
        else if (userguess > guessnumber)
        {
            InfoText.text = "You number is greater than the guess number";
        }
        else
        {
            InfoText.text = "You number is less than the guess number";
        }
        Input.text = "";
        Input.ActivateInputField();

    }   
        
    
	
}
