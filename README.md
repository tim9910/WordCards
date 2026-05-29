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
|**發音播放**     | ![播放](https://github.com/tim9910/tim9910.github.io/blob/main/images/wavplayer/play.png) |點擊**播放**按鈕可播放單字發音  |
|**發音停止**     | ![停止播放](https://github.com/tim9910/tim9910.github.io/blob/main/images/wavplayer/stop.png) |點擊**停止**按鈕可停止單字發音  |
|**按鈕互動效果** |  |滑鼠移到按鈕會放大，移開會變回原來大小。並切換**播放**或**停止**的圖示。  |
|**單字切換**     | ![單字切換](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/enter.png) |使用 Enter 鍵切換至下一個單字或點選左側單字列表進行切換  |
|**單字編輯**     |  |在左側單字列表中雙擊（Double Click）單字，即可開啟單字編輯視窗 |
|**重複播放**     | ![重複播放](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/spacekey.png) |按 Space 鍵重複播放目前單字發音  |


## :pushpin: 貼心輔助

  ![貼心輔助](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/info2.gif)

## :pushpin: 系統操作流程及畫面

### STEP1: 開啟程式後，左側顯示單字列表
  
### STEP2: 點選(單擊)單字，右側查看詳細內容
  
### STEP3: 按**播放**按鈕播放發音，並逐一往下播放，可按**停止**按鈕停止播放。

### STEP4: 快捷鍵操作
- Enter 鍵：切換至下一個單字
- Space 鍵：重複播放目前單字發音

### STEP5: 雙擊（Double Click）單字開啟單字編輯視窗
- 當音標、音檔路徑、解釋資料檔有異動時，**儲存**按鈕自動啟用。按**儲存**鍵後，更新後的資料會立刻顯示在「解釋」欄位。
- 關閉視窗即取消儲存。
- 取消儲存或儲存完成，都會有訊息提示。

  ![系統操作](https://github.com/tim9910/tim9910.github.io/blob/main/images/wordcards/runapp.gif)