using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private TMP_Text health;
    [SerializeField] private Slider slider;

    private void Start()
    {
        UpdateHealthBar(1);
    }

    public void UpdateHealthBar(float ratio)
    {
        health.text = (ratio * 100).ToString();
        slider.value = ratio;
    }
}