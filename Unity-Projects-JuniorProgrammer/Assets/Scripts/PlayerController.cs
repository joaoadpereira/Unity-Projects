using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Fields

    [SerializeField] float speed = 5.0f;
    Vector3 vehiclePosition;

    #endregion

    #region Properties

    /// <summary>
    /// Returns the position of the vehicle
    /// </summary>
    public Vector3 VehiclePosition
    {
        get { return vehiclePosition; }
    }

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        transform.Translate(speed * Vector3.forward * Time.deltaTime);

        //define vehicle position
        vehiclePosition = transform.position;
    }
}
