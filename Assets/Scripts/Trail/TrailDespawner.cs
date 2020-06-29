using UnityEngine;

public class TrailDespawner : MonoBehaviour
{
    public Transform playerTrail;

    [SerializeField]
    private int maxTrailCount = 10;

    private void Update()
    {
        if (playerTrail.childCount > maxTrailCount)
        {
            var blob = playerTrail.GetChild(0).gameObject;
            Destroy(blob);
        }
    }
}
