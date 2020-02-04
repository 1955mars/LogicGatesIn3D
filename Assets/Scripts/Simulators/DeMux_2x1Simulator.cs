using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeMux_2x1Simulator : GateSimulator
{
    public MeshRenderer inputD;
    public MeshRenderer inputX;
    public MeshRenderer outputA;
    public MeshRenderer outputB;

    void Update()
    {
        if (isSimulating && timeCounter >= timeP)
        {
            bool valueD = false;
            bool valueX = false;

            if (counter == 0)
            {
                valueD = false;
                valueX = false;
            }
            else if (counter == 1)
            {
                valueD = false;
                valueX = true;
            }
            else if (counter == 2)
            {
                valueD = true;
                valueX = false;
            }
            else if (counter == 3)
            {
                valueD = true;
                valueX = true;
            }


            inputD.material = valueD ? onMat : offMat;
            inputX.material = valueX ? onMat : offMat;
            bool[] outp = DeMux2x1G.Logic(valueD, valueX);
            //Debug.Log("inputA " + valueA + " inputB " + valueB + " output " + outp);
            outputA.material = outp[0] ? onMat : offMat;
            outputB.material = outp[1] ? onMat : offMat;

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
