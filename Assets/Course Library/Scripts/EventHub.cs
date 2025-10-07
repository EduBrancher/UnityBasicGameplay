using System;
using UnityEngine;

public class EventHub : MonoBehaviour {
    public static System.Action AnimalCrossedBottom;

    public static void OnAnimalCrossedBottom() {
        AnimalCrossedBottom?.Invoke();
    }
}
