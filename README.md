# color_space
yamanaka_copy

山中の引継ぎのための勉強用リポジトリです。<br>
C++およびｃ＃でのOpenCVの使い方(基本のキ)を学びます。<br>
ご不明点あればお気軽にご連絡ください＝＞ymnkaki0135[atto]gmail.com<br>
 
# OpenCVとは
画像処理がなんでもできる<br>
基本はC+とpython<br>
バージョンでまま挙動が違うから管理注意<br>
本体のほかにcontribという有志のコードがある。これをC++で使うにはcmakeしないといけない<br>
(とても大変です、ググってください。)<br>
 
# Install
## C++
OpenCVを「OpenCV documents」で検索、バージョンをしっかり明記して保存<br>
VSソリューションエクスプローラ、プロパティから、<br>
C++->全般->追加のインクルードに～build\install\includeまでのパスを<br>
リンカ―->全般->追加のライブラリに～build\install\x64\vc16\binまでのパスと～build\install\x64\vc16\lib<br>
リンカ―->入力->追加の依存ファイルにopencv_world<version>d.libを追加 ex.opencv_world440d.lib<br>
 ```
 他にも環境変数をいじったり、思いプロパティファイル？をいれとくなどあるそうですが、↑が一番いいです。もっといいのは↓です。
```
これを毎回するのがめんどくさいと思った人は、[VSのデフォを変える](https://detail.chiebukuro.yahoo.co.jp/qa/question_detail/q11111008231)という方法があります。<br>

 ## C#
 プロジェクト->Nugetパッケージの管理->参照でOpenCVの管理<br>
 指示に従うままコードにusingの追加<br>
```
 あー簡単。
```
 ## Python
 プレゼントマークから管理<br>
 opencv-pythonをインストール<br>
 立ち上げなおす
 ```
 あー簡単。すごい簡単。
```
 
 # 本リポジトリでの目標
 * このリポジトリのC++およびC#が実行できるようにする(pythonはおまけ)
 * C++のコードをc#に改変する
 * それらで追加の機能を作ってみる
 
 # 次の目標
 * 山中のコードを理解して改良してもらう
 
# License
恥ずかしいのでVebots限定です。
 
 # Githubの勉強
 * readme
 * cloneとfork<br>
 僕の理解<br>
 ![clone_fork](https://user-images.githubusercontent.com/63694987/129294615-8a03e09a-6c27-4dff-b676-3f214432e9de.png)<br>
 だから、forkして、developを[name/purpose]とかでbranchして適宜push必要ならpull request、承認後mergeと思われる。<br>
 なお、この図はdiagrams.netというもので書いた。非常に便利。
