using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    public Gradient gradient;

    public Image Fill;

    public void SetMaxHealth(int Health)
    {
        slider.maxValue = Health;
        slider.value = Health;
        gradient.Evaluate(1f);
    }
    public void SetHealth (int Health)
    {
        slider.value = Health;
        Fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
