using UnityEngine;
using TMPro;

public class LevelFinished : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Ball ball))
        {
            Debug.Log("Level Finished");
        }
    }
}
