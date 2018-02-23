using UnityEngine;

namespace Utils
{
    [ExecuteInEditMode]
    public class Comment: MonoBehaviour
    {
        [TextArea(3, 5)]
        [SerializeField] private string _text;

        private void Awake()
        {
            tag = "EditorOnly";
        }
    }
}
