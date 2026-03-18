using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskBar : MonoBehaviour
{
    public Image Top;
    [SerializeField] GameObject TaskPrefab;
   

    private void Awake()
    {
        Top.color = new Color(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f), Random.Range(0.5f, 1f));
    }
    public void DestroyThis()
    {
        Destroy(gameObject);
    }

    public void AddNewTask()
    {
        GameObject newTask = Instantiate(TaskPrefab, GetComponent<RecyclableScrollRect>().content);
        GetComponent<RecyclableScrollRect>().ReloadData(); 
    }
}
