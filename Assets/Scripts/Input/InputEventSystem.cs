using UnityEngine;

namespace Input
{
    public class InputEventSystem : MonoBehaviour
    {
        //Singleton Pattern
        public static InputEventSystem Instance { get; private set; }
        private void Awake() 
        { 
            if (Instance != null && Instance != this) 
            { 
                Destroy(this); 
            } 
            else 
            { 
                Instance = this; 
            } 
        }
        
    }
}
