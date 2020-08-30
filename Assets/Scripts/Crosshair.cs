using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public UiObjectName UiObjectName;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            GameObject go = hit.transform.gameObject;
            DisplayObjectName(go);
        }
    }

    private void DisplayObjectName(GameObject go)
    {
        Game game = go.GetComponent<Game>();
        UiObjectName.gameObject.SetActive(game != null);

        if (game != null)
        {
            UiObjectName.ObjectName = game.GameName;
        }
    }
}
