   M S B A M L   `   `   `  ���� F  BMy_Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:My_Project1My_Project1      My_Project1.For_Personal   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:My_Project1       � Title$  For_Personal��$	��450��$	��830�� � 
ResizeMode$ NoResize=����	#FF273341.��� .+��� .+�o� 
������� � Cursor$
 Hand������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFFF9700��$ 1Q�.@�m� $��Меню��$
 Hand��
�������.@�m� -    m�Name$ miBackSignIn��$;��5Вернуться в окно авторизации��
����������� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 1Q�� $ 	#FFDC8200��m� -   $ miCLose��$��Закрыть��
����������� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FFCD7900��$ 1Q�m� -   $ miHelp��$��Помощь��$
 Hand���� $��Заказы�����	#FF273341
�������.��&   System.Windows.Controls.DataGrid  -     Name$ dgOrder��$��0,0,9,0q�	   AutoGenerateColumns	 .  
   CanUserReorderColumns
 .     RowDetailsVisibilityMode$ Visible=�   
IsReadOnly . ���	#FF478DD1���	#FF1E2C35���	#FF1E2C35$
��Bold"�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Название��   
IsReadOnly .    
Foreground �	#FF1E2C35   
FontWeight$
 Bold"�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *NAME_SUBJECT+  $ Тематика�� .  �	#FF1E2C35$
 Bold"� �� *
NAME_ORDER+  $ Стоимость�� .  �	#FF1E2C35$
 Bold"� �� *PRICE+  $% Время выполнения�� .  �	#FF1E2C35$
 Bold"� �� *
RUN_TIME+  $ Исполнитель��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 90  .  �	#FF1E2C35$
 Bold"� �� *
PERFOMER+  $1 +Коммментарий заказчика��$	 300  .  �	#FF1E2C35$
 Bold"� �� *	COMMENT+  $# Прогресс заказа��$	 100  �	#FF1E2C35$
 Bold"� �� *PROGRESS_ORDER+