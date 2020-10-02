# Labocket ～XRによる理科学習サポートアプリケーション～

## 動作環境
ios11以上が動作するiPhone6s以降のiPhone

## Scene(.unity)
### Title
　タイトル画面
### License
　ライセンス画面
### Menu
　メインメニュー画面
### AtomMenu
　「ARでつくる」「図鑑」選択画面
### AtomCollection
　図鑑表示画面
### GradeMenu
　実験学年選択画面
### LabMenu
　選択した学年の実験一覧画面(どの学年を選択してもこのシーンへ遷移)
### Main
　VR実験シーン

## Script(.cs)
### AqueousControl
### Atom
　原子分子に紐づく情報をアセットとして登録するためのスクリプト
　格納してある情報を関数で取得できる
### AtomDB
　Atom.csで作られたアセットをListとしてGUI管理するためのスクリプト  
　ほかのスクリプトから関数でリストを取得できる
### BTB
### BackButtonExit
### CanCarryObject
### CollectionManager
### DisplayAtomCard
　AtomCollection.unityで、原子分子の情報を横スクロールメニューに表示するためのスクリプト  
　取得したリストのサイズ分追加するため原子分子の追加にも対応
### DisplayLabCard
　LabMenu.unityで、実験の情報を横スクロールメニューに表示するためのスクリプト  
　取得したリストのサイズ分追加するため実験の追加にも対応
### HandVRController
### HitObject
### IControlObject
### Lab
　各実験情報をアセットとして登録するためのスクリプト  
　格納してあるデータを関数で取得できる
### LabDB
　Lab.csで作られたアセットをListとしてGUI管理するためのスクリプト  
　ほかのスクリプトから関数でリストを取得できる。
　学年ごとにListを作成する。
### License
### Menu(いらん？)
### Menubutton
　UIメニューのボタンを押したときの挙動をまとめたスクリプト  
### TestScript(いらん？)

## Resources
### Image
　UIメニューで用いる画像を格納
### Atom
　Atom.cs,AtomDB.csで作った、原子分子情報アセットを格納
### Lab
　Lab.cs,LabDB.csで作った、実験情報アセットを格納
### mov
## Materials
