using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class RaycastCam : MonoBehaviour
    {
        RaycastHit hit;

        void Update()
        {
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (!Input.GetMouseButtonDown(0)) return;
            //if (Physics.Raycast(ray, out hit))
            //{
            //    var korpus = hit.transform.GetComponent<KorpusScript>();
            //    korpus.Click();
            //}
        }
    }
}
