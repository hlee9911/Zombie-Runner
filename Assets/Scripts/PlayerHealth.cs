using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHP = 100f;
    [SerializeField] private float currentHP;

    private DeathHandler deathHandler;

    void Start()
    {
        currentHP = maxHP;
        Debug.Log($"Current HP: {currentHP}");
        deathHandler = GetComponent<DeathHandler>();
    }

    public void PlayerTakeDamage(float dmgMult)
    {
        currentHP = Mathf.Clamp(currentHP - dmgMult, 0f, maxHP);
        Debug.Log($"Current HP: {currentHP}");
        if (currentHP <= 0f)
        {
            if (deathHandler)
            {
                deathHandler.HandleDeath();
            }
            // Destroy(gameObject);
        }
    }


}
