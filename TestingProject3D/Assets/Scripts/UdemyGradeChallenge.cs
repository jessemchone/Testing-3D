using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UdemyGradeChallenge : MonoBehaviour
{
    [SerializeField] float[] grades;
    [SerializeField] float[] grades2;
    //[SerializeField] float grade1;
    //[SerializeField] float grade2;
    //[SerializeField] float grade3;
    //[SerializeField] float grade4;
    //[SerializeField] float grade5;

    private float gradesTotal = 0;
    private float gradeAverage = 0;
    private int numberOfGrades = 0;

    // Start is called before the first frame update
    void Start()
    {
        // This is the basic way
        //gradeAverage = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

        CalculateAverageGrade(grades2);

        if (gradeAverage >= 90)
        {
            Debug.Log("The average is an A");
        }
        else if (gradeAverage >= 80 && gradeAverage < 90)
        {
            Debug.Log("The average is a B");
        }
        else if (gradeAverage >= 70 && gradeAverage < 80)
        {
            Debug.Log("The average is a C");
        }
        else
        {
            Debug.Log("The average is an F");
        }

        Debug.Log("The number of grades is " + numberOfGrades);
    }

    private void CalculateAverageGrade(float[] grades)
    {
        foreach (float grade in grades)
        {
            numberOfGrades++;

            gradesTotal += grade;
            //gradeAverage += grade;

            gradeAverage = gradesTotal / numberOfGrades;

            // The below didn't work, I think it's because it keeps re-calculating it each time (100 / 1 = 100 + 90 / 2 = 145 etc.)
            //gradeAverage /= numberOfGrades;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
