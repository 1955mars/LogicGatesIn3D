using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrSimulator : GateSimulator
{
    public MeshRenderer inputA;
    public MeshRenderer inputB;
    public MeshRenderer output;

    void Update()
    {
        if (isSimulating && timeCounter >= timeP)
        {
            bool valueA = false;
            bool valueB = false;

            if (counter == 0)
            {
                valueA = false;
                valueB = false;

            }
            else if (counter == 1)
            {
                valueA = false;
                valueB = true;
            }
            else if (counter == 2)
            {
                valueA = true;
                valueB = false;
            }
            else if (counter == 3)
            {
                valueA = true;
                valueB = true;
            }

            inputA.material = valueA ? onMat : offMat;
            inputB.material = valueB ? onMat : offMat;
            bool outp = OrG.Logic(valueA, valueB);
            //Debug.Log("inputA " + valueA + " inputB " + valueB + " output " + outp);
            output.material = outp ? onMat : offMat;

            counter++;

            if (counter >= 4)
            {
                counter = 0;
            }

            timeCounter = 0.0f;
        }
        timeCounter += Time.deltaTime;
    }
}
