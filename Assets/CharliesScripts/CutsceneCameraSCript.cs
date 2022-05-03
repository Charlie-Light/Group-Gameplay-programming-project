using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneCameraSCript : MonoBehaviour
{
    public List<Vector3> movement_points;

    public bool is_active = false;
    public bool loop = false;
    public bool teleport_to_start = false;
    public float speed_mod;

    public GameObject player_cam_ref;
    public GameObject camera_To_move_to;
    public GameObject lookAt;

    private bool reverse = false;
    private bool move_to_next_point = true;
    public int current_point;
    private bool do_once = true;


    void Start()
    {
        movement_points.Add(camera_To_move_to.transform.localPosition);
        movement_points.Add(player_cam_ref.transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (is_active)
        {
            if(do_once)
            {
                do_once = false;
                movement_points[0] = player_cam_ref.transform.position;
                movement_points[1] = camera_To_move_to.transform.position;
                this.transform.position = movement_points[0];
            }

            if (move_to_next_point)
            {
                updateMovement();
            }
            flipMovement();
        }
    }

    private void updateMovement()
    {

        float step = speed_mod * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, movement_points[current_point], step);
        if (reverse && AlmostEqual(this.transform.position, player_cam_ref.transform.localPosition))
        {
            print("YES");
        }
    }

    private void flipMovement()
    {
        if (AlmostEqual(this.transform.localPosition, movement_points[current_point]))
        {

            if (reverse)
            {
                //is reverseing
                if (current_point == 0)
                {
                    if (teleport_to_start)
                    {
                        current_point = 0;
                        transform.localPosition = movement_points[0];
                    }
                    else
                    {
                        reverse = false;
                    }
                }
                else
                {
                    current_point -= 1;
                }
            }
            else
            {
                //is not reverseing 
                if (current_point == movement_points.Count - 1)
                {
                    if (loop)
                    {
                        if (teleport_to_start)
                        {
                            current_point = 0;
                            transform.localPosition = movement_points[0];
                        }
                        else
                        {
                            reverse = true;
                        }

                    }
                    else
                    {
                        is_active = false;
                    }
                }
                else
                {
                    current_point += 1;
                }
            }
        }
    }

    private bool AlmostEqual(Vector3 v1, Vector3 v2)
    {
        if (Mathf.Abs(v1.x - v2.x) > 0.1) return false;
        if (Mathf.Abs(v1.y - v2.y) > 0.1) return false;
        if (Mathf.Abs(v1.z - v2.z) > 0.1) return false;

        return true;
    }
}
