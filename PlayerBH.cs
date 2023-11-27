using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBH : MonoBehaviour
{
    // Start is called before the first frame update

    public int MaxHealth = 100;
    public bool Hit = false;
    public int CurrentHealth = 0;

    public int AttackRangeMin;
    public int AttackRangeMex;

    public int Ap;
    public int AttackRange;

    public HealthBarScript healthbar;
    private void Start()
    {
        CurrentHealth = MaxHealth;
        healthbar.SetMaxHealth(MaxHealth);
    }

    private void Update()
    {
        if (Hit || Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(1);
            Hit = false;
        }

    }

    void takeDamage(int damage)
    {
        CurrentHealth -= damage;
        healthbar.SetHealth(CurrentHealth);
    }



}
