using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using PolyAndCode.UI;

// Handles editing/configuring a TaskCell (UI form for task details)
public class TaskConfigurator : MonoBehaviour
{
    // Reference to the currently edited TaskCell
    [SerializeField] TaskCell myCell;

    // UI input fields for editing task data
    [SerializeField] TMP_InputField TaskName;
    [SerializeField] TMP_Text Username;
    [SerializeField] TMP_InputField content;
    [SerializeField] TMP_InputField endDate;

    // Displays assigned users (not fully used here)
    [SerializeField] TMP_Text AssignedUsers;

    // Currently selected player for assignment
    public Player assignedPlayer;

    // Scroll view for displaying selected users locally
    [SerializeField] RecyclableScrollRect LocalRect;

    // Prefab used to show assigned user in the UI
    [SerializeField] GameObject LocalUserPrefab;

    // Loads data from a TaskCell into the configurator UI
    public void ImportTask(TaskCell cell)
    {
        // Store reference to the task being edited
        myCell = cell;

        // Populate UI fields with existing task data
        TaskName.text = cell.TaskName.text;
        Username.text = cell.UserName.text;
        content.text = cell.content;

        // Format DateTime into a readable string (YYYY-MM-DD)
        endDate.text = cell.endDate.ToString("yyyy-MM-dd");
    }

    // Saves changes from UI back into the TaskCell
    public void SaveCurrentTask()
    {
        // Update the TaskCell with edited values
        myCell.SetTaskCell(
            TaskName.text,
            Username.text,
            content.text,
            DateTime.Parse(endDate.text), // NOTE: can throw error if format is invalid
            assignedPlayer
        );
    }

    // Assigns a player to the task via the configurator
    public void SetPlayer(Player p)
    {
        // Store selected player
        assignedPlayer = p;

        // Create a UI element showing the assigned player
        GameObject LocalUserAdded = Instantiate(LocalUserPrefab, LocalRect.content);

        // Refresh scroll view to update layout
        LocalRect.ReloadData();

        // Set displayed name on the UI element
        LocalUserAdded.GetComponent<DemoCell>().nameLabel.text = p.Name;
    }

    // Called once per frame (currently unused)
    void Update()
    {

    }
}