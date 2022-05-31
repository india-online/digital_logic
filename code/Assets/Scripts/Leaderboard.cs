using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {
    DataInsert dataInsert;
    Boolean listUpdated = false;
	// Use this for initialization
	void Start () {
        GameObject dataInsertGO = new GameObject("dbConn");
        dataInsertGO.transform.parent = this.gameObject.transform;
        dataInsert = dataInsertGO.AddComponent<DataInsert>();
    }
	
	// Update is called once per frame
	void Update () {
		if(listUpdated == false && dataInsert.isDataObtained == true)
        {
            Debug.Log("Lab 1 top 10");
            List<int> Lab1Grades = dataInsert.getAllLab1Grades();
            for(int i = 0; i < 10 && i < Lab1Grades.Count; i++)
            {
                Debug.Log(Lab1Grades[i]);
                GameObject textGO = new GameObject("Grade");
                textGO.transform.parent = this.gameObject.transform;
                Text text = textGO.AddComponent<Text>();
                text.text = Lab1Grades[i] + "";
                text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
                text.color = Color.black;
                textGO.transform.localScale = new Vector3(1, 1, 1);
                textGO.transform.localPosition = new Vector3(-110f, 120f - i*30f, 0f);

            }
            List<int> Lab2Grades = dataInsert.getAllLab2Grades();
            for (int i = 0; i < 10 && i < Lab2Grades.Count; i++)
            {
                Debug.Log(Lab2Grades[i]);
                GameObject textGO = new GameObject("Grade");
                textGO.transform.parent = this.gameObject.transform;
                Text text = textGO.AddComponent<Text>();
                text.text = Lab2Grades[i] + "";
                text.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
                text.color = Color.black;
                textGO.transform.localScale = new Vector3(1, 1, 1);
                textGO.transform.localPosition = new Vector3(170f, 120f - i * 30f, 0f);
            }
            listUpdated = true;
        }
	}
}
