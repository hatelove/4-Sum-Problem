Feature: 數字組合
	In order to 證明小朋友是對的，題目空格是錯的
	As a 不想動腦的老爸
	I want to 輸入一個期望的總和，就找出四個數字的組合

Scenario: 四個數字加總為 15 的組合
	Given 總和為 15	
	When I 呼叫人體計算機時
	Then 結果應為
	| First | Second | Third | Fourth |
	| 1     | 2      | 3     | 9      |
	| 1     | 2      | 4     | 8      |
	| 1     | 2      | 5     | 7      |
	| 1     | 3      | 4     | 7      |
	| 1     | 3      | 5     | 6      |
	| 2     | 3      | 4     | 6      |
	
