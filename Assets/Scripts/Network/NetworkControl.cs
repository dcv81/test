using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class NetworkControl : NetworkBehaviour
{
    [Networked] public bool IsMainPlayer { get; set; }
    private static bool mainPlayerAssigned = false;

    public override void Spawned()
    {
        if (Runner.IsServer) // Solo el servidor asigna el rol de jugador principal
        {
            if (!mainPlayerAssigned)
            {
                // Asigna el rol de jugador principal al primer jugador que se conecta
                IsMainPlayer = true;
                mainPlayerAssigned = true;
                Debug.Log("Jugador principal asignado");
            }
        }
        else
        {
            Debug.Log("No es el servidor, no se asigna rol");
        }
    }
}
