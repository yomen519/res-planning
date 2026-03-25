using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TaskConfigurator : MonoBehaviour
{
    [SerializeField] TaskCell myCell;
    [SerializeField] TMP_InputField TaskName;
    [SerializeField] TMP_Text Username;
    [SerializeField] TMP_InputField content;
    [SerializeField] TMP_InputField endDate;
    [SerializeField] TMP_Text AssignedUsers; 
    public Player assignedPlayer; 

    public void ImportTask(TaskCell cell)
    {
        myCell = cell; 
        TaskName.text = cell.TaskName.text;
        Username.text = cell.UserName.text;
        content.text = cell.content;
        endDate.text = cell.endDate.ToString("yyyy-MM-dd");

    }
    public void SaveCurrentTask()
    {

        myCell.SetTaskCell(TaskName.text, Username.text, content.text, DateTime.Parse(endDate.text),assignedPlayer);
    }
    public void SetPlayer(Player p)
    {
        assignedPlayer = p;
        AssignedUsers.text = assignedPlayer.Name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
