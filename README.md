# color_space
yamanaka_copy

山中の引継ぎのための勉強用リポジトリです。<br>
C++およびｃ＃でのOpenCVの使い方(基本のキ)を学びます。<br>
ご不明点あればお気軽にご連絡ください＝＞ymnkaki0135[atto]gmail.com<br>
 
# OpenCVとは
画像処理がなんでもできる<br>
基本はC+とpython<br>
バージョンでまま挙動が違うから管理注意<br>
本体のほかにcontribという有志のコードがある。これをｃ＋で使うにはcmakeしないといけない<br>
 
# Install
## C++
OpenCVを検索、バージョンをしっかり明記して保存<br>
VSソリューションエクスプローラ、プロパティから、<br>
C++->全般->追加のインクルードに～～～～build\install\includeまでのパスを<br>
リンカ―->全般->追加のライブラリに～～～～build\install\x64\vc16\binまでのパスと～～～～build\install\x64\vc16\lib<br>
リンカ―->入力->追加の依存ファイルにopencv_world<version>d.libを追加 ex.opencv_world440d.lib<br>
これを毎回するのがめんどくさいと思った人は、[VSのデフォを変える](https://detail.chiebukuro.yahoo.co.jp/qa/question_detail/q11111008231)という方法があります。<br>

 ## C#
 プロジェクト->Nugetパッケージの管理->参照でOpenCVの管理<br>
 指示に従うままコードにusingの追加<br>
```
 あー簡単。
```
 
 # 本リポジトリでの目標
 * このリポジトリのC++およびC#が実行できるようにする
 * C++のコードをc#に改変する
 * それらで追加の機能を作ってみる
 
  # 次の目標
 * 山中のコードを理解して改良してもらう
 
# License
恥ずかしいのでVebots限定です。
