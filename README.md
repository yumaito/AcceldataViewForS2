# AcceldataViewForS2
S2初心者のための加速度センサビュワー

シリアル通信で加速度センサのデータを見るためのC#用ライブラリです。
対応している加速度センサは以下です。

* WAA-010

### 構成

プロジェクトの構成は以下の通りです。
* Accelerometer: 加速度データを表すライブラリ本体
* accelView_classes: 加速度データを見るFormアプリ

### 使い方
基本的にはそのままビルドするだけで動きます。

ライブラリ単体で使う場合は、dllを参照後、以下のusingディレクティブを参照します。

```csharp
using accelerometer;
```

次の変数をグローバルで宣言しておきます。

```csharp
delegate void setfocus();
```

シリアル通信の受信イベントの箇所に以下を追加します

```csharp
private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArdgs e)
{
  BeginInvoke((setfocus)delegate()
  {
    string r = serialPort1.ReadExisting();
    //その他データ受信毎に行いたい処理
  });
}
```
