# color_space
yamanaka_copy

山中の引継ぎのための勉強用リポジトリです。
C++およびｃ＃でのOpenCVの使い方(基本のキ)を学びます。
ご不明点あればお気軽にご連絡ください＝＞ymnkaki0135[atto]gmail.com
 
#　OpenCVとは
画像処理がなんでもできる
基本はC+とpython
バージョンでまま挙動が違うから管理注意
本体のほかにcontribという有志のコードがある。これをｃ＋で使うにはcmakeしないといけない
 
# Install
*C++
OpenCVを検索、バージョンをしっかり明記して保存
VSソリューションエクスプローラ、プロパティから
C++->全般->追加のインクルードに～～～～build\install\includeまでのパスを
リンカ―->全般->追加のライブラリに～～～～build\install\x64\vc16\binまでのパスと～～～～build\install\x64\vc16\lib
リンカ―->入力->追加の依存ファイルにopencv_world<version>d.libを追加 ex.opencv_world440d.lib
 これを毎回するのがめんどくさいと思った人は、VSのデフォを変えるという方法があります。https://detail.chiebukuro.yahoo.co.jp/qa/question_detail/q11111008231
*C#

 
# License
恥ずかしいのでVebots限定です。
