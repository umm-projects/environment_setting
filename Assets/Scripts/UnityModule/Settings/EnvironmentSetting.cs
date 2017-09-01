
namespace UnityModule.Settings {

    /// <summary>
    /// 環境設定
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial class EnvironmentSetting : Setting<EnvironmentSetting> {

#if UNITY_EDITOR

        /// <summary>
        /// 環境設定アセットを生成する
        /// </summary>
        [UnityEditor.MenuItem("Assets/Create/Setting/EnvironmentSetting")]
        public static void CreateEnvironmentSetting() {
            CreateAsset();
        }

#endif

    }
}
