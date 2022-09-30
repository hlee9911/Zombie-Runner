using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamageTaken : MonoBehaviour
{
    [SerializeField] private Canvas DamageCanvas;
    [SerializeField] private float impactTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        DamageCanvas.enabled = false;
    }

    public void ShowDamageCanvas()
    {
        StartCoroutine(ShowImage());
    }

    IEnumerator ShowImage()
    {
        DamageCanvas.enabled = true;
        yield return new WaitForSeconds(impactTime);
        DamageCanvas.enabled = false;
    }
}
