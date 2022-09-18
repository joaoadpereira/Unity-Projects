using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    #region Fields

    //Support vehicle position identification
    [SerializeField] GameObject vehicle;
    PlayerController playerController;
    Vector3 vehicleToFollowPosition;

    //support camera positioning 
    [SerializeField] Vector3 cameraAdustment =new Vector3();

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Access vehicle 
        playerController = vehicle.GetComponent<PlayerController>();

    }

    /// <summary>
    /// Updates after vehicle Update()
    /// </summary>
    void LateUpdate()
    {
        //Get vehicle position
        vehicleToFollowPosition = playerController.VehiclePosition;

        //Set camera position 
        transform.position=(vehicleToFollowPosition + cameraAdustment);
        
    }
}
