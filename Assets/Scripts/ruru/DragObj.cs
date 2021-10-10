using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObj : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    CanvasGroup canvasGroup = null;

    RectTransform rect = null;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rect = GetComponent<RectTransform>();

        //rect.rotation = Quaternion.Euler(0,0,30) ;

        //HandCardRotation();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       // canvasGroup.blocksRaycasts = true;
    }

    // éËéùÇøÉJÅ[ÉhÇÃâÒì]
    void HandCardRotation()
    {
        int index = transform.GetSiblingIndex();

        Debug.Log(index);

        switch (index)
        {
            case 0:
                rect.rotation = Quaternion.Euler(0, 0, 40);
                break;
            case 1:
                rect.rotation = Quaternion.Euler(0, 0, 20);
                break;
            case 2:
                rect.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 3:
                rect.rotation = Quaternion.Euler(0, 0, -20);
                break;
            case 4:
                rect.rotation = Quaternion.Euler(0, 0, -40);
                break;

        }
    }
}
