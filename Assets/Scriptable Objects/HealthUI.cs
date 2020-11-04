using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    public PlayerHealth playerHealth;

    private Image _image;

    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        playerHealth.OnHealthChange+=OnPlayerHealthChange;
    }

    private void OnPlayerHealthChange(int health)
    {
        _image.fillAmount =health*1.0f/playerHealth.MaxHealth*1.0f;
    }
}
