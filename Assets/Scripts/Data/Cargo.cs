using CargoView = Player.Cargo.View;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "Cargo", menuName = "Static Data/Cargo")]
    public class Cargo : ScriptableObject
    {
        public CargoView[] сargoList;
    }
}
