using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mux_2x1Simulator : GateSimulator
{
    public MeshRenderer inputA;
    public MeshRenderer inputB;
    public MeshRenderer inputX;
    public MeshRenderer output;

    void Update()
    {
        if (isSimulating && timeCounter >= timeP)
        {
            bool valueA = false;
            bool valueB = false;
            bool valueX = false;

            if (counter == 0)
            {
                valueX = false;
                valueA = false;
                valueB = false;
            }
            else if (counter == 1)
            {
                valueX = false;
                valueA = false;
                valueB = true;
            }
            else if (counter == 2)
            {
                valueX = false;
                valueA = true;
                valueB = false;
            }
            else if (counter == 3)
            {
                valueX = false;
                valueA = true;
                valueB = true;
            }
            else if (counter == 4)
            {
                valueX = true;
                valueA = false;
                valueB = false;
            }
            else if (counter == 5)
            {
                valueX = true;
                valueA = false;
                valueB = true;
            }
            else if (counter == 6)
            {
                valueX = true;
                valueA = true;
                valueB = false;
            }
            else if (counter == 7)
            {
                valueX = true;
                valueA = true;
                valueB = true;
            }

            inputA.material = valueA ? onMat : offMat;
            inputB.material = valueB ? onMat : offMat;
            inputX.material = valueX ? onMat : offMat;
            bool outp = Mux2x1G.Logic(valueA, valueB, valueX);
            //Debug.Log("inputA " + valueA + " inputB " + valueB + " output " + outp);
            output.material = outp ? onMat : offMat;

            counter++;

            if (counter >= 8)
            {
                counter = 0;
            }

            timeCounter = 0.0f;
        }
        timeCounter += Time.deltaTime;
    }
}
