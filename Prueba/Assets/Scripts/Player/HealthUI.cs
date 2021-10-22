using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image[] HealthIcons;

    public void UpdateHealth(int CurrentHealth)
    {
        for (int i = 0; i < (HealthIcons.Length); i++) 
        {
            if (i < CurrentHealth)
            {
                HealthIcons[i].enabled = true;
            }
            else
            {
                HealthIcons[i].enabled = false;
            }
        }
    }
}
