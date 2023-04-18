using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;


    private void Start()
    {
        // var file = Directory.C
        var directoryPath = Application.dataPath;
        var files = Directory.GetFiles(directoryPath, "*.mp4");
    }
}
