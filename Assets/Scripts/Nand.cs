using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nand : MonoBehaviour
{
    public GameObject gateBody;
    public GameObject inputConnA;
    public GameObject inputConnB;
    public GameObject outputConn;

    public Material wireOnMat;
    public Material wireOffMat;

    Wire inputWireA;
    Wire inputWireB;
    Wire outputWire;


    // Start is called before the first frame update
    void Start()
    {
        inputWireA = inputConnA.GetComponent<Wire>();
        inputWireB = inputConnB.GetComponent<Wire>();
        outputWire = outputConn.GetComponent<Wire>();
    }

    public void SetInputs(bool vol)
    {
        inputWireA.SetVoltage(vol);
    }

    public bool NandGate(bool inputA, bool inputB)
    {
        inputWireA.SetVoltage(inputA);
        inputWireB.SetVoltage(inputB);
        outputWire.SetVoltage(!(inputWireA.GetVoltage() & inputWireB.GetVoltage()));
        return outputWire.GetVoltage();
    }

}
