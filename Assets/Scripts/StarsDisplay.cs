﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text startText;
    // Start is called before the first frame update
    void Start()
    {
        startText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        startText.text = stars.ToString();
    }
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }
    public void SpendStars(int amount)
    {
        if(stars > amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        
    }

}
