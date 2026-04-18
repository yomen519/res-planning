using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Represents a single task item in the UI
public class TaskCell : MonoBehaviour
{
    // UI text fields for displaying task name and assigned user
    public TMP_Text TaskName, UserName;

    // Task data
    public string content;          // Task description/content
    public DateTime endDate;        // Task deadline
    public Player assignedPlayer;  // Player assigned to this task

    // Background or visual image for the task (used for color coding)
    [SerializeField] Image TaskImage;

    // Called when the object is initialized
    private void Awake()
    {
        // Set initial color based on parent TaskBar
        UpdateColor();
    }

    // Updates the task color based on its parent TaskBar
    public void UpdateColor()
    {
        // Check if this object is inside a TaskBar
        if (GetComponentInParent<TaskBar>())
        {
            // Match the color of the TaskBar's top image
            TaskImage.color = GetComponentInParent<TaskBar>().Top.color;
        }
    }

    // Sets all task data at once
    public void SetTaskCell(string n, string username, string c, DateTime d, Player p)
    {
        SetTaskName(n);
        SetUserName(username);
        SetContent(c);
        SetDate(d);

        // Only assign player if it's not null
        if (p != null)
            SetPlayer(p);
    }

    // Opens a configurator/editor and passes this task to it
    public void ExportTaskCell()
    {
        // Find all TaskConfigurator objects (even inactive ones)
        TaskConfigurator[] objs = Resources.FindObjectsOfTypeAll<TaskConfigurator>() as TaskConfigurator[];

        // Activate the first configurator found
        objs[0].gameObject.SetActive(true);

        // Send this task's data to the configurator
        FindObjectOfType<TaskConfigurator>().ImportTask(this);
    }

    // Sets the task name in UI
    void SetTaskName(string n)
    {
        TaskName.text = n;
    }

    // Sets the user name in UI
    void SetUserName(string username)
    {
        UserName.text = username;
    }

    // Stores task content/description
    void SetContent(string C)
    {
        content = C;
    }

    // Stores task deadline
    void SetDate(DateTime d)
    {
        endDate = d;
    }

    // Deletes this task object
    public void DestroyThis()
    {
        Destroy(gameObject);
    }

    // Assigns a player to the task and updates UI
    void SetPlayer(Player player)
    {
        assignedPlayer = player;

        // Update displayed username based on player data
        SetUserName(player.Name);
    }
}