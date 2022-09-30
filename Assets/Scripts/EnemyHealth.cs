using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float MaxHitPoints = 100f;
    [SerializeField] private float currentHitPoints;

    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }

    void Start()
    {
        currentHitPoints = MaxHitPoints;
    }

    // create a public method which reduces hitpoints by the amount of damage
    public void TakeDamage(float dmgMult)
    {
        BroadcastMessage("OnDamageTaken");
        currentHitPoints = Mathf.Clamp(currentHitPoints - dmgMult, 0, MaxHitPoints);
        if (currentHitPoints <= 0f)
        {
            ProcessDie();
            // Destroy(gameObject);
        }
    }

    void ProcessDie()
    {
        if (isDead) { return; }
        isDead = true;
        GetComponent<Animator>().SetTrigger("Dead");
    }
}
