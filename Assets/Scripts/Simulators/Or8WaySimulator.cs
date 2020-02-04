using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Or8WaySimulator : GateSimulator
{
    public MeshRenderer[] inputA;
    public MeshRenderer output;

    void Update()
    {
        if (isSimulating && timeCounter >= timeP)
        {
            bool[] valueA = new bool[8];

            int temp = counter;
            int tempCounter = 0;
            while(true)
            {
                if (temp <= 0)
                    break;
                valueA[tempCounter] = (temp % 2 == 0) ? false : true;
                temp = temp / 2;
                tempCounter++;
            }

            bool outp = Or8WayC.Logic(valueA);

            for(int i=0; i<8; i++)
            {
                inputA[i].material = valueA[i] ? onMat : offMat;
                
            }
            output.material = outp ? onMat : offMat;

            counter++;

            if (counter >= UnityEngine.Mathf.Pow(2,8))
            {
                counter = 0;
            }

            timeCounter = 0.0f;
        }
        timeCounter += Time.deltaTime;
    }
}
