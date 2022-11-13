using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardsBehaviour : MonoBehaviour
{
    public bool interact;

    HazardMeterBehaviour hmb;

    private void Start()
    {
        GameObject HazardMeter = GameObject.Find("HazardFill");
        hmb = HazardMeter.GetComponent<HazardMeterBehaviour>();
    }

    //Investigate: If player is by the object and E is pressed
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && interact == true)
        {
            Destroy(gameObject);
            hmb.HazardInc();
        }
    }

    //check if player is by the object
    void OnTriggerEnter2D(Collider2D target)
    {
        interact = true;
    }

    void OnTriggerExit2D(Collider2D target)
    {
        interact = false;
    }
}
