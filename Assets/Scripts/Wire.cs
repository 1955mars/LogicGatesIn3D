using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{

    bool voltage;

    MeshRenderer meshR;
    Nand nandGate;
    // Start is called before the first frame update
    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        nandGate = GetComponentInParent<Nand>();
    }

    public void SetVoltage(bool vol)
    {
        voltage = vol;
        meshR.material = voltage ? nandGate.wireOnMat : nandGate.wireOffMat;
    }

    public bool GetVoltage()
    {
        return voltage;
    }
}
