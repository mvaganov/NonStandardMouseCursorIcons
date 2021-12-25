#if UNITY_EDITOR
using UnityEditor;
namespace NonStandard.MouseCursor {
    [InitializeOnLoad] public static class UiText_Define { static UiText_Define() { Utility.Define.Add("NONSTANDARD_MOUSECURSOR"); } }
}
#endif
