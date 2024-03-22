using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    [SerializeField] private Camera m_Camera;
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
  
  
   

    private void FixedUpdate()
    {
        Vector3 start = m_Camera.transform.position;
        Vector3 targetPosion = player.transform.position;
        m_Camera.transform.position = Vector3.Lerp(start,new Vector3(player.transform.position.x,0.0f,-10f), Time.deltaTime);
    }
}
