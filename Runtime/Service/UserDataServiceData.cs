using UnityEngine;

namespace Rossoforge.UserData.Service
{
    [CreateAssetMenu(fileName = nameof(UserDataServiceData), menuName = "Rossoforge/UserData/Service Data")]
    public class UserDataServiceData : ScriptableObject
    {
        [field: SerializeField]
        public string FileName { get; private set; }

        [field: SerializeField]
        public string EncoderKey { get; private set; }
    }
}
