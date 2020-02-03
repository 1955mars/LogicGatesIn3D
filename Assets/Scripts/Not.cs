using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Not : MonoBehaviour
{
    Nand nandGate1;
    // Start is called before the first frame update
    void Start()
    {
        nandGate1 = new Nand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool NotGate(bool inputA)
    {
        return NandGate(inputA, inputA);
    }
}
