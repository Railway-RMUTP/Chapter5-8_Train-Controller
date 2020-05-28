using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineController : MonoBehaviour
{
    public Animator cubeAni;
    public bool EngineOn;

    public void SetEngine() {
        if (cubeAni == null)
            return;
        EngineOn = !EngineOn;
    }

    void FixedUpdate () {
        if (EngineOn) {
            cubeAni.Play ("EngineOn");
        } else
            cubeAni.Play ("EngineOff");
    }

    private void Start () {
        cubeAni.GetComponent<Animator> ();
    }
}
