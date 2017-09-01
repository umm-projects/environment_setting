# What?

* 開発環境に関わる設定ファイルを提供します。
* このクラス単体では何も提供しませんが、`partial` クラスとして定義しているので、他のモジュールで設定を追加することができます。
* このクラスは Unity のメニューとして `Assets` &gt; `Create` &gt; `Setting` &gt; `EnvironmentSetting` を提供するだけです。

# Why?

* 環境依存な項目を簡便に取り扱える設定クラスが欲しかったので作りました。

# Install

```shell
$ npm install @umm/environment_setting
```

# Usage

```csharp
using UnityEngine;

namespace UnityModule.Settings {

    public partial class EnvironmentSetting : Setting<EnvironmentSetting> {

        [SerializeField]
        private bool hoge = true;

        public bool Hoge {
            get {
                return this.hoge;
            }
            set {
                this.hoge = value;
            }
        }

    }

}
```

* 追加したい設定フィールドを実装したクラスとして `UnityModule.Settings.EnvironmentSetting` を実装します。
    * クラス名は固定です。
* このクラスによって提供される `Assets/Resources/Settings/EnvironmentSetting.asset` は VCS 管理しないようにしましょう。
    * VCS から除外する場合は適切にデフォルト値を設定しておかないと実機実行時に問題になることがあるので注意しましょう。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

