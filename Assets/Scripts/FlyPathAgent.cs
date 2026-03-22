
using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed;

    private int nextIndex = 1;

    void Start()
    {
        if (flyPath != null && flyPath.waypoints != null && flyPath.waypoints.Length > 0)
        {
            transform.position = flyPath[0];

            Debug.Log(gameObject.name + " sinh ra tại: " + transform.position);
        }
        else
        {
            Debug.LogError(gameObject.name + " chưa được gán FlyPath!");
        }
    }

    void Update()
    {
        if (flyPath == null || flyPath.waypoints == null || flyPath.waypoints.Length == 0) return;

        if (nextIndex >= flyPath.waypoints.Length)
        {
            Destroy(gameObject);
            return;
        }

        FlyToNextWaypoint();

        if (nextIndex < flyPath.waypoints.Length)
        {
            LookAt(flyPath[nextIndex]);
        }
    }

    private void FlyToNextWaypoint()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            flyPath[nextIndex],
            flySpeed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, flyPath[nextIndex]) < 0.01f)
        {
            nextIndex++;
        }
    }

    private void LookAt(Vector2 destination)
    {
        Vector2 dir = destination - (Vector2)transform.position;
        if (dir.sqrMagnitude < 0.0001f) return;

        float angle = Vector2.SignedAngle(Vector2.down, dir);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}