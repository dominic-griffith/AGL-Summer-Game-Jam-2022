using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeCursor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Texture2D cursorOpen;
    [SerializeField] private Texture2D cursorClose;
    private Vector2 cursorHotspot = new Vector2(16f, 16f);

    void IPointerEnterHandler.OnPointerEnter(PointerEventData pointerEventData)
    {
        Cursor.SetCursor(cursorClose, cursorHotspot, CursorMode.Auto);
    }
    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorOpen, cursorHotspot, CursorMode.Auto);
    }
}
