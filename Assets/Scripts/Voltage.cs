using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voltage : MonoBehaviour
{

    public Wire[] wires;

    public bool isHigh;
    public Material[] mats;

    MeshRenderer meshR;
    bool prevState;
    // Start is called before the first frame update
    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        prevState = !isHigh;
        SetVoltageOnWires();
    }

    // Update is called once per frame
    void Update()
    {
        if(prevState != isHigh)
        {
            meshR.material = mats[isHigh?1:0];
            prevState = isHigh;
            SetVoltageOnWires();
        }

    }

    public bool GetInput()
    {
        return isHigh;
    }

    void SetVoltageOnWires()
    {
        foreach(Wire w in wires)
        {
            w.SetVoltage(isHigh);
        }
    }
}
