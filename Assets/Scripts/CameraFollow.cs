using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform Target;
    public bool Start = true;

    // Update is called once per frame
    void Update()
    {
        if (Start == true)
        {
            Vector3 newPos = new Vector3(Target.position.x, (Target.position.y + 2), -10);
            transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime); //Follows Player
        }


        if (Input.GetKeyDown(KeyCode.E)) //When E is pressed, the camera will snap to a fixed position but NOT follow the player
        {

           Quaternion targetRotation = Quaternion.LookRotation(Target.position - transform.position);
           transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, FollowSpeed * Time.deltaTime);
           transform.position = new Vector3(5, Target.position.y + 2, -10);
            Vector3 newPos1 = new Vector3(Target.position.x, (Target.position.y + 2), -10);
            Start = false;
        }
    }
}
