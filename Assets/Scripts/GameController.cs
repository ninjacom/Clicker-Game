﻿using UnityEngine;
using UnityEngine.UI; // Text

public class GameController : MonoBehaviour {

    // How much cash the player has
    private float _cash;
    public float Cash
    {
        get
        {
            return _cash;
        }
        set
        {
            _cash = value;
            cashText.text = "You have: $" + _cash.ToString("0.00");
        }
    }

    /// How much cash is automatically earned per second
    private float _cashPerSecond;
    public float CashPerSecond
    {
        get
        {
            return _cashPerSecond;
        }
        set
        {
            _cashPerSecond = value;
            rateText.text = "per second: " + _cashPerSecond.ToString("0.0");
        }
    }

    [Tooltip("How much cash players will make when they hit the button.")]
    public float cashPerClick = 1;
    [Header("Object References")]
    public Text cashText;
    public Text rateText;


    void Start () {
        Cash = 0;
        CashPerSecond = 0;
    }
	
	void Update () {
        Cash += CashPerSecond * Time.deltaTime;
    }

    public void ClickedButton()
    {
        Cash += cashPerClick;
    }
}
