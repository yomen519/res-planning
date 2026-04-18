using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Handles dragging behavior for a UI element (likely a task item)
public class Dragme : MonoBehaviour
{
    // Tracks whether the object is currently being dragged
    private bool isDragging = false;

    // Reference to the main canvas (used for proper UI positioning)
    public Canvas parentCanvas;

    // Called on start
    void Start()
    {
        // Find the first Canvas in the scene (not ideal for performance, but works)
        parentCanvas = FindObjectOfType<Canvas>();
    }

    // Placeholder for click logic
    public void OnClick()
    {
        // Currently unused
    }

    // Called when dragging begins
    public void OnBeginDrag()
    {
        // Disable raycast so this object doesn't block drop targets
        GetComponentInChildren<Image>().raycastTarget = false;

        // Set dragging flag
        this.isDragging = true;

        // Move object to root canvas so it renders on top of everything
        transform.SetParent(parentCanvas.transform);

        // Ensure it is drawn last (on top)
        transform.SetAsLastSibling();

        // Refresh all scroll views to update layout
        foreach (RecyclableScrollRect s in FindObjectsOfType<RecyclableScrollRect>())
        {
            s.ReloadData();
        }
    }

    // Called when dragging ends
    public void OnEndDrag()
    {
        // (This condition currently does nothing)
        if (this.isDragging == false) { }

        // Stop dragging
        this.isDragging = false;

        // Snap object to the closest scroll container
        transform.SetParent(GetClosestObject().cont);

        // Refresh all scroll views
        foreach (RecyclableScrollRect s in FindObjectsOfType<RecyclableScrollRect>())
        {
            s.ReloadData();
        }

        // Update visuals of all task cells (e.g., color changes)
        foreach (TaskCell c in FindObjectsOfType<TaskCell>())
        {
            c.UpdateColor();
        }
    }

    // Called when pointer (mouse/finger) is released
    public void OnPointerUp()
    {
        // Snap object to closest container again (safety)
        transform.SetParent(GetClosestObject().cont);

        // Re-enable raycast so UI can be interacted with again
        GetComponentInChildren<Image>().raycastTarget = true;

        // (This condition currently does nothing)
        if (this.isDragging == false) { }

        // Ensure dragging flag is reset
        this.isDragging = false;
    }

    // Called every frame
    void Update()
    {
        // If dragging, update position to follow the mouse
        if (isDragging)
        {
            Vector2 movePos;

            // Convert screen position to local position inside the canvas
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                parentCanvas.transform as RectTransform,
                Input.mousePosition,
                parentCanvas.worldCamera,
                out movePos
            );

            // Move object to calculated position
            transform.position = parentCanvas.transform.TransformPoint(movePos);
        }
    }

    // Finds the closest vertical RecyclableScrollRect to this object
    public RecyclableScrollRect GetClosestObject()
    {
        float closest = 1000000000; // large initial distance
        RecyclableScrollRect closestObject = null;

        // Loop through all scroll rects in the scene
        for (int i = 0; i < FindObjectsOfType<RecyclableScrollRect>().Length; i++)
        {
            // Calculate distance to current scroll rect
            float dist = Vector3.Distance(
                FindObjectsOfType<RecyclableScrollRect>()[i].transform.position,
                transform.position
            );

            // Check if closer AND not horizontal (only vertical lists allowed)
            if (dist < closest &&
                FindObjectsOfType<RecyclableScrollRect>()[i].Direction != RecyclableScrollRect.DirectionType.Horizontal)
            {
                closest = dist;
                closestObject = FindObjectsOfType<RecyclableScrollRect>()[i];
            }
        }

        // Return the closest valid scroll rect
        return closestObject;
    }
}