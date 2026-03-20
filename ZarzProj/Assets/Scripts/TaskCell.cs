using System;
using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;
using UnityEngine.UI;


public class TaskCell : MonoBehaviour
{
    public TMP_Text TaskName, UserName;
    public string content;
    public DateTime endDate;
    [SerializeField]Image TaskImage;
    private void Awake()
    {
        UpdateColor();
    }
    public void UpdateColor()
    {
        if(GetComponentInParent<TaskBar>())
        TaskImage.color = GetComponentInParent<TaskBar>().Top.color;
    }
    public void SetTaskCell(string n, string username, string c, DateTime d)
    {
        SetTaskName(n); 
        SetUserName(username);
        SetContent(c);
        SetDate(d);
        
    }
    public void ExportTaskCell()
    {
        TaskConfigurator[] objs = Resources.FindObjectsOfTypeAll<TaskConfigurator>() as TaskConfigurator[];
        objs[0].gameObject.SetActive(true);
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
    public void DestroyThis()
    {
        Destroy(gameObject);
    }

}
