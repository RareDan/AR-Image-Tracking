using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                if (Physics.Raycast(ray, out hit))
                {
                    VideoPlayer videoPlayer = hit.transform.gameObject.GetComponent<VideoPlayer>();

                    if (!videoPlayer) return;

                    if (videoPlayer.isPlaying)
                    {
                        videoPlayer.Pause();
                    }
                    else
                    {
                        videoPlayer.Play();
                    }
                }
            }
        }

        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {

            }
        }
    }

    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         Ray ray = Camera.main.ScreenPointToRay(new Vector2(512, 960));
    //         Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 9999);

    //         if (Physics.Raycast(ray, out hit))
    //         {
    //             VideoPlayer videoPlayer = hit.transform.gameObject.GetComponent<VideoPlayer>();

    //             if (!videoPlayer) return;

    //             if (videoPlayer.isPlaying)
    //             {
    //                 videoPlayer.Pause();
    //             }
    //             else
    //             {
    //                 videoPlayer.Play();
    //             }
    //         }
    //     }

    // }
}
