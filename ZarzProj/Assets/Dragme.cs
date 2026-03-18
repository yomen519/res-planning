using PolyAndCode.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class Dragme : MonoBehaviour
    {
        private bool isDragging = false;
       public Canvas parentCanvas;
    

    void Start()
    {
        parentCanvas = GetComponentInParent<Canvas>(); 
    }
    public void OnClick()
    {
      
    }
    public void OnBeginDrag()
        {
        GetComponentInChildren<Image>().raycastTarget = false; 
            this.isDragging = true;
             transform.SetParent(parentCanvas.transform);
             transform.SetAsLastSibling();
     

    }
    public void OnEndDrag()
    {
        if (this.isDragging == false) { }
        this.isDragging = false;
        transform.SetParent(GetClosestObject().cont);
  
    }
        public void OnPointerUp()
    {
        transform.SetParent(GetClosestObject().cont);
   
        
        GetComponentInChildren<Image>().raycastTarget = true;
        if (this.isDragging == false) {  }
            this.isDragging = false;

      

    }
    void Update()
    {
        if (isDragging)
        {
            Vector2 movePos;

    RectTransformUtility.ScreenPointToLocalPointInRectangle(
        parentCanvas.transform as RectTransform,
        Input.mousePosition, parentCanvas.worldCamera,
        out movePos);

    transform.position = parentCanvas.transform.TransformPoint(movePos);
        }
    }
    public RecyclableScrollRect GetClosestObject()
    {
        float closest = 1000000000; //add your max range here
        RecyclableScrollRect closestObject = null;
        for (int i = 0; i < FindObjectsOfType<RecyclableScrollRect>().Length; i++)  //list of gameObjects to search through
        {
            float dist = Vector3.Distance(FindObjectsOfType<RecyclableScrollRect>()[i].transform.position, transform.position);
            if (dist < closest)
            {
                closest = dist;
                closestObject = FindObjectsOfType<RecyclableScrollRect>()[i];
            }
        }
        return closestObject;
    }
}

