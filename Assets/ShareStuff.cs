using UnityEngine;
using DreamCode.EasyShare;

using System.IO;
public class ShareStuff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        ScreenCapture.CaptureScreenshot("Test.png");
        var imagePath = Path.Combine(Application.persistentDataPath, "Test.png");

        ShareService.SendBinaryContent(
                        filePath: imagePath,
                        mimeType: MimeTypeNames.Image,
                        message: "Content with image",
                        sharedByActivity: packageName => { Debug.Log($"SendBinaryContent:{packageName}"); });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
