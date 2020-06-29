using UnityEngine;
public class TrailSpawner : MonoBehaviour
{
    public Transform player;
    public Transform playerTrail;
    public GameObject trailBlob;

    [SerializeField]
    private float trailDropTime = .5f;
    [SerializeField]
    private PlayerInput input;
    private float timer = 0;

    private int trailCount = 0;

    private void Start()
    {
        input = player.gameObject.GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if (input.Movement.sqrMagnitude > 0)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
        }

        if (timer > trailDropTime)
        {
            // Spawn a blob at location
            var Blob = Instantiate(trailBlob);
            Blob.transform.parent = playerTrail;
            Blob.transform.position = player.position;
            Blob.transform.SetAsLastSibling();


            // Reset timer and increase trail count 
            timer = 0;
            trailCount += 1;
        }
    }

}