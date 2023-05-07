using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  public GameObject player;
  private Vector3 offset = new Vector3(0, 11, -16);

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void LateUpdate()
  {
    // follow player with camera and adjust with offset
    transform.position = player.transform.position + offset;
  }
}
