using System;
using UnityEngine;

namespace UnityModule.Settings {

    /// <summary>
    /// 環境設定
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial class EnvironmentSetting : Setting<EnvironmentSetting> {

        /// <summary>
        /// パス管理クラス
        /// </summary>
        /// <remarks>partial 定義しているので、このクラスにフィールドを追加する形で拡張可能にしてあります</remarks>
        [Serializable]
        // ReSharper disable once PartialTypeWithSinglePart
        public partial class EnvironmentSetting_Path {
        }

        /// <summary>
        /// パス管理クラスのインスタンスの実体
        /// </summary>
        [SerializeField]
        private EnvironmentSetting_Path path;

        /// <summary>
        /// パス管理クラスのインスタンス
        /// </summary>
        public EnvironmentSetting_Path Path {
            get {
                if (this.path == default(EnvironmentSetting_Path)) {
                    this.path = new EnvironmentSetting_Path();
                }
                return this.path;
            }
            set {
                this.path = value;
            }
        }

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
