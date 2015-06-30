# AcceldataViewForS2
S2初心者のための加速度センサビュワー

シリアル通信で加速度センサのデータを見るためのC#用ライブラリです。
対応している加速度センサは以下です。

* WAA-010
* TSND121(現在実装中)

### 構成

プロジェクトの構成は以下の通りです。

* Accelerometer: 加速度データを表すライブラリ本体
* accelView_classes: 加速度データを見るFormアプリ

### 使い方
基本的にはそのままビルドするだけで動きますが、加速度センサに送信するコマンドは自身で書いてください。

Form.cs内の`SerialOpen()`関数内の`string cmd`がそのコマンドです。  
同じ関数内の`sensorData`がデータを管理するクラスのコンストラクタです。  
引数は以下の通りです。

1. 第1引数  
データのタイプを指定する列挙体です。 

    ```csharp
    dataType.both //加速度データおよび角速度データを両方とも取得する場合
    dataType.accel //加速度データのみを取得する場合
    dataTyep.gyro //角速度データのみを取得する場合
    ```

1. 第2引数  
 センサーの型番を指定する列挙体です。

    ```csharp
    SensorVer.WAA010
    SensorVer.TSND121
    ```

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
  Invoke((setfocus)delegate()
  {
    byte[] buffer = new byte[serialPort1.ReadBufferSize];
    int t = serialPort1.Read(buffer,0,buffer.Length);
    sensorData.pushDataBuffer(buffer);
    //その他データ受信毎に行いたい処理
  });
}
```

シリアル通信で送信するコマンドはセンサの型番によって変わります。WAA-010の場合はstring型でTSND121の場合はbyte[]型で作成します。TSND121でコマンドの最後に必要なBCCは以下の関数で取得できます。

```csharp
byte[] cm = new byte[]{...};//コマンド（BCCを除く）
byte[] c = SensorConfig.MakeCommand(SensorVer.TSND121,cm);//cmの末尾にBCCが追加される
```

string型を送信するときは`serialPort1.WriteLine(cmd);`でbyte[]を送信するときは`serialPort1.Write(c,0,c.Length);`で送信します。
