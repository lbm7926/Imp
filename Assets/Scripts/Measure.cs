using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Measure : MonoBehaviour
{
    bool startPress;
    Vector3 startPos;
    Vector3 endPos;

    public GameObject startSphere;
    public GameObject endSphere;
    public LineRenderer line;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                startPress = true;
                if (startPos == Vector3.zero)
                {
                    startSphere.SetActive(true);
                    endSphere.SetActive(true);
                    startPos = hit.point;
                    startSphere.transform.position = startPos;

                    line.SetPosition(0, hit.point);
                }
            }

        }

        if (startPress)
        {
            line.gameObject.SetActive(true);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                line.SetPosition(1, hit.point);
            }
            else
            {
                Vector3 pp = Input.mousePosition;
                Vector3 uu = Camera.main.ScreenToWorldPoint(new Vector3(pp.x, pp.y, 2));
                line.SetPosition(1, uu);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            line.gameObject.SetActive(false);
            startPress = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (startPos != Vector3.zero)
                {
                    endPos = hit.point;
                    startSphere.SetActive(false);
                    endSphere.SetActive(false);
                    float length = Calculate(startPos, endPos);
                }
            }
        }

        //if (Input.GetMouseButtonDown(0))
        //{           
            
        //    line.SetPosition(0,hit.point);
        //    startPos = hit.point;
        //}

        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (Physics.Raycast(ray,out hit,1000)&&Input.GetMouseButton(0))
        //{
        //    line.SetPosition(1,hit.point);
        //}

    }

    RaycastHit hit;
    Ray ray;


    float Calculate(Vector3 start,Vector3 end)
    {
        Vector3 length = start - end;

        return length.magnitude;
    }
}
