   M S B A M L   `   `   `  ����F  BMy_Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:My_Project1My_Project1  5   	       My_Project1.For_Personal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:My_Project1     5   	     � Title$  For_Personal��5   	   $	��450��6   $	��830��6+    � 
ResizeMode$ NoResize=�5	   	   ���	#FF273341.��5      � .+�5   
   �� .+�5      o� 
������� � Cursor$
 Hand��6&   ��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5      $ 	#FFFF9700��6'   $ 1Q�69   5      .@�5      m� $��Меню��6   $
 Hand��6)   
�������.@�5      m� -   5         m�Name$ miBackSignIn��5      $;��5Вернуться в окно авторизации��65   
���������5      �� 5      $ 0.5,1&�62   $ 0.5,0&�6C   .��5   "   � $ Black��6/   $ 1Q�6=   � 5   "   $ 	#FFDC8200��6/   5      5      m� 5      -   5        $ miCLose��5      $��Закрыть��60   
���������5      �� 5       $ 0.5,1&�62   $ 0.5,0&�6C   .��5!   "   � $ Black��6/   $ 0Q�6=   � 5"   "   $ 	#FFCD7900��6/   $ 1Q�6A   5#      5%      5&      m� 5'      -   5        $ miHelp��5'      $��Помощь��6+   $
 Hand��6P   5(      �� 5)      $��Заказы��6   ���	#FF273341
�������.��5*      &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrder��5*      $��0,0,9,0q�6,   	   AutoGenerateColumns	 .  
   CanUserReorderColumns
 .     RowDetailsVisibilityMode$ Visible=�6w      
IsReadOnly . ���	#FF478DD1���	#FF1E2C35���	#FF1E2C35$
��Bold"�6%     Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6-      
IsReadOnly .    
Foreground �	#FF1E2C35   
FontWeight$
 Bold"�6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *NAME_SUBJECT+6�     5-      $ Тематика��6-    .  �	#FF1E2C35$
 Bold"�6�    6?   �� *
NAME_ORDER+6�     5.      $ Стоимость��6-    .  �	#FF1E2C35$
 Bold"�6�    6@   �� *PRICE+6�     5/      $% Время выполнения��6-    .  �	#FF1E2C35$
 Bold"�6�    6G   �� *
RUN_TIME+6�     50      $ Исполнитель��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6B    .  �	#FF1E2C35$
 Bold"�6�    6M   �� *
PERFOMER+6�     51      $1 +Коммментарий заказчика��6-   $	 300 6i    .  �	#FF1E2C35$
 Bold"�6�    6M   �� *	COMMENT+6�     52      $# Прогресс заказа��6-   $	 100 6i    �	#FF1E2C35$
 Bold"�6�    6F   �� *PROGRESS_ORDER+6�   54      55      56      57      58      