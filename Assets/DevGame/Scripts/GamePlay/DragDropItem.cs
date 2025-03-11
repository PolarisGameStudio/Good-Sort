using UnityEngine;

public class DragDropItem : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset = new Vector3(0, -0.5f, 0);
    private Transform objDrag = null;

    private Item trObjDrag = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D[] hits = Physics2D.RaycastAll(mousePos, Vector2.zero);

            if (hits.Length > 0)
            {
                foreach (var hit in hits)
                {
                    trObjDrag = hit.collider.GetComponent<Item>();
                    if(trObjDrag != null)
                    {
                        trObjDrag.BeginDrag();
                        break;
                    }
                }
            }

            isDragging = true;
        }

        if (Input.GetMouseButton(0) && isDragging && trObjDrag != null) 
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            trObjDrag.transform.position = mousePosition + (Vector2)offset;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(trObjDrag != null)
            {
                trObjDrag.EndDrag();

                Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                RaycastHit2D[] hits = Physics2D.RaycastAll(mousePos, Vector2.zero);

                if (hits.Length > 0)
                {
                    bool isDragSucess = false;
                    foreach (var hit in hits)
                    {
                        var cell = hit.collider.GetComponent<Cell>();
                        if (cell != null && !cell.IsLock)
                        {
                            isDragSucess = true;
                            Debug.Log("current_cell_" + cell.name);
                            trObjDrag.CheckEndItem(cell);
                            LogicGame.Instance.UserClickScreen();
                            break;
                        }
                    }

                    if(!isDragSucess)
                    {
                        trObjDrag.OnMoveFailed();
                    }
                }
                else
                {
                    trObjDrag.OnMoveFailed();
                }
            }

            isDragging = false;
            trObjDrag = null;
        }
    }
}
