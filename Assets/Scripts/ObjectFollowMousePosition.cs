using UnityEngine;

public class ObjectFollowMousePosition : MonoBehaviour
{
    private ObjectDetector ObjectDetector;

    public void Setup(ObjectDetector ObjectDetector)
    {
        this.ObjectDetector = ObjectDetector;
    }

    private void Update()
    {
        if(ObjectDetector == null) return;

        transform.position = ObjectDetector.GetPointerWorldPosition();
    }
}
