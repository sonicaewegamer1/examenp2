using UnityEngine;

public class switchmode : MonoBehaviour

  {
    // modelo robot
    public GameObject robotMode;

    // modelo vehiculo
    public GameObject vehicleMode;

    // estado actual
    private bool isVehicleMode = false;

    void Update()
    {
        // cambiar modo al presionar E
        if (Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }
    }

    void Switch()
    {
        // cambiar estado
        isVehicleMode = !isVehicleMode;

        // activar/desactivar modelosel toggle
        robotMode.SetActive(!isVehicleMode);
        vehicleMode.SetActive(isVehicleMode);
    }
}