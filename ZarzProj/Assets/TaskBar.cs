using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Handles a task bar UI element (likely a list of tasks inside a scroll view)
public class TaskBar : MonoBehaviour
{
    // Reference to the top UI image (used for visual styling)
    public Image Top;

    // Prefab used to create new task UI elements
    [SerializeField] GameObject TaskPrefab;

    // Called when the script instance is being loaded
    private void Awake()
    {
        // Assign a random bright-ish color to the Top image
        // (values between 0.5 and 1 to avoid very dark colors)
        Top.color = new Color(
            Random.Range(0.5f, 1f),
            Random.Range(0.5f, 1f),
            Random.Range(0.5f, 1f)
        );
    }

    // Destroys this TaskBar object
    public void DestroyThis()
    {
        Destroy(gameObject);
    }

    // Creates a new task item inside the scroll view
    public void AddNewTask()
    {
        // Instantiate a new task as a child of the scroll view content
        GameObject newTask = Instantiate(
            TaskPrefab,
            GetComponent<RecyclableScrollRect>().content
        );

        // Refresh the scroll view so it updates its layout/data
        GetComponent<RecyclableScrollRect>().ReloadData();
    }
}