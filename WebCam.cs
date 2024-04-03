using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    [SerializeField] RawImage img = default;
    private WebCamTexture webCamTexture;

    private void Start()
    {
        webCamTexture = new WebCamTexture();
        if(!webCamTexture.isPlaying) webCamTexture.Play();
        img.texture = webCamTexture;
    }
    //This scritp only need a UI Raw Image load the raw imgage on the field and boom goes the dynamite. -_-
}
