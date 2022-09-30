using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // [SerializeField] private int maxAmmoAmount = 10;
    // [SerializeField] private int currentAmmoAmount;
    [SerializeField]
    AmmoSlot[] ammoSlots;


    [System.Serializable]
    private class AmmoSlot
    {
        public AmmoType ammoType;
        // public int maxAmmoAmount;
        public int currentAmmoAmount;
    }

    void Start()
    {
        // currentammoamount = maxammoamount;
    }

    public int GetCurrentAmmo(AmmoType ammoType)
    {
        return GetAmmoSlot(ammoType).currentAmmoAmount;
    }

    public void ReduceCurrentAmmo(AmmoType ammoType)
    {
        GetAmmoSlot(ammoType).currentAmmoAmount = Mathf.Clamp(GetAmmoSlot(ammoType).currentAmmoAmount - 1, 0, 100);
    }

    public void IncreaseCurrentAmmo(AmmoType ammoType, int ammoMult)
    {
        GetAmmoSlot(ammoType).currentAmmoAmount += ammoMult;
    }

    private AmmoSlot GetAmmoSlot(AmmoType ammoType)
    {
        foreach (AmmoSlot slot in ammoSlots)
        {
            if (slot.ammoType == ammoType)
            {
                return slot;
            }
        }
        return null;
    }

}
