# 單字卡程式

## :pushpin: 概述
**單字卡程式** 是一個簡單的 **Windows Forms** 應用程式，提供左右分割介面，左側為單字列表，右側顯示單字、音標與中文解釋等詳細資訊，同時支援語音播放與快捷鍵操作（Enter→下一個、Space→重複）。此外，亦提供單字編輯功能，使用者可修改單字資料內容(音標、音檔位置及解釋)，並即時更新內容。

## :pushpin: UI介面

  ![UI介面](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/ui.png)

## :pushpin: 開發環境

- **語言**：C#
- **IDE**：Visual Studio 2022
- **平台**：Windows

## :pushpin: 功能說明

|      功能       |   圖示  |     功能說明           |
|-----------------|---------|------------------------|
|**發音播放**     | ![播放](https://github.com/tim9910/tim9910.github.io/blob/main/images/wavplayer/play.png) |點擊播放按鈕可播放單字發音  |
|**單字切換**     |  |使用 Enter 鍵切換至下一個單字或點選左側清單進行切換  |
|**單字編輯**     |  |在左側單字列表中雙擊（Double Click）單字，即可載入並顯示詳細內容進行編輯。 |
|**重複播放**     |  |按 Space 鍵可重複播放目前單字發音  |
|**按鈕互動效果** |  |滑鼠移到按鈕會放大，移開會變回原來大小。會切換播放或停止的圖示。  |

## :pushpin: 貼心輔助

  ![貼心輔助](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/info2.gif)

## :pushpin: 系統操作流程及畫面

### STEP1: 開啟程式後，左側顯示單字列表
  
### STEP2: 點選單字，右側查看詳細內容
  
### STEP3: 按播放鍵播放發音，可停止播放。

### STEP4: 快捷鍵操作
- Enter 鍵：切換至下一個單字
- Space 鍵：重複播放目前單字發音

### STEP5: 雙擊（Double Click）單字載入編輯單字視窗

  ![系統操作](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/runapp.gif)