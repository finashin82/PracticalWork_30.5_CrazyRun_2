using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject cameraPlayer;

    [SerializeField] private GameObject cameraReview;

    public void CameraPlayer()
    {
        cameraReview.SetActive(false);

        cameraPlayer.SetActive(true);
    }

    public void CameraReview()
    {
        cameraPlayer.SetActive(false);

        cameraReview.SetActive(true);        
    }
}
