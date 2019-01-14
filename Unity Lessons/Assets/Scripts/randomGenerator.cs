using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomGenerator : MonoBehaviour {

    private int chosenNum;

    public Transform cube;
	
	
	void Update ()
    {
        //Step();
        StepLeft();
        //StepArray();
	}

    private void Step()
    {
        float StepX = 0f;
        float StepZ = 0f;

        chosenNum = Random.Range(0, 4);

        if(chosenNum == 0)
        {
            StepX = -0.1f;
        }

        else if (chosenNum == 1)
        {
            StepX = 0.1f;
        }
        else if ( chosenNum == 2)
        {
            StepZ = -0.1f;
        }

        else if ( chosenNum == 3)
        {
            StepZ = 0.1f;
        }

        cube.position += new Vector3(StepX, 0f, StepZ);
    }
    private void StepLeft()
    {
        float StepX = 0f;
        float StepZ = 0f;

        chosenNum = Random.Range(0, 5);

        if (chosenNum == 0 || chosenNum == 4)
        {
            StepX = -0.1f;
        }

        else if (chosenNum == 1)
        {
            StepX = 0.1f;
        }
        else if (chosenNum == 2)
        {
            StepZ = -0.1f;
        }

        else if (chosenNum == 3)
        {
            StepZ = 0.1f;
        }

        cube.position += new Vector3(StepX, 0f, StepZ);
    }

    private void StepArray()
    {
        int[] elements = new int[5];

        elements[0] = 0;
        elements[1] = 1;
        elements[2] = 2;
        elements[3] = 3;
        elements[4] = 0;

        int randomIndex = Random.Range(0, 5);

        float StepX = 0f;
        float StepZ = 0f;

        chosenNum = elements[randomIndex];

        if (chosenNum == 0)
        {
            StepX = -0.1f;
        }

        else if (chosenNum == 1)
        {
            StepX = 0.1f;
        }
        else if (chosenNum == 2)
        {
            StepZ = -0.1f;
        }

        else if (chosenNum == 3)
        {
            StepZ = 0.1f;
        }

        cube.position += new Vector3(StepX, 0f, StepZ);
    }

    private void StepCurve ()
    {
        float randomCurveValue = Random.Range(0.0f, 1.0f);
        float randomValue = 

    }
}
