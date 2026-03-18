using System;
using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;


public class TaskCell : MonoBehaviour
{
    public TMP_Text TaskName, UserName;
    public string content;
    public DateTime endDate;
  

    public void SetTaskCell(string n, string username, string c, DateTime d)
    {
        SetTaskName(n); 
        SetUserName(username);
        SetContent(c);
        SetDate(d);
    }
    public void ExportTaskCell()
    {
        FindInActiveObjectByName("Current Task").SetActive(true);
        FindObjectOfType<TaskConfigurator>().ImportTask(this);
    }
     void SetTaskName(string n)
    {
        TaskName.text = n; 
    }
     void SetUserName(string username)
    {
        UserName.text = username; 
    }
     void SetContent(string C)
    {
        content = C; 
    }
     void SetDate(DateTime d)
    {
        endDate = d; 
    }
    // Update is called once per frame
    void Update()
    {

    }
    GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].name == name)
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }
}
