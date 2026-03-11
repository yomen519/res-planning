using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



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
            this.isDragging = true;
             transform.SetParent(parentCanvas.transform);
             transform.SetAsLastSibling(); 
        }
        public void OnPointerUp()
        {
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
}

