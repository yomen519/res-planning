using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskBarPanel : MonoBehaviour
{
    [SerializeField] GameObject TaskCellPrefab;
    [SerializeField] RecyclableScrollRect scrollRect;
    public void AddTaskBar()
    {
        GameObject newTaskBar = Instantiate(TaskCellPrefab, transform);
        newTaskBar.transform.SetAsLastSibling();
        scrollRect.ReloadData();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
