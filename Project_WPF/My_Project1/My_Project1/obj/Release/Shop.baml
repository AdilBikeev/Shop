   M S B A M L   `   `   `  ���� F  BMy_Project1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:My_Project1My_Project1      My_Project1.Shop   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:My_Project1       � Title$
  Shop��$��484.981��$��863.851�� � 
ResizeMode$ NoResize=����	#FF1E2C35 � 	Resources  �� MergedDictionaries �� Source��  �� $ Dictionary1.xaml?�%    .��� .+��� .+�o� $	��Top=� � Cursor$
 Hand�����	#FF3E3E40
�������.@�m� $��Меню��$
 Hand��
�������.@�m� -    m�Name$ miBackSignIn��$;��5Вернуться в окно авторизации��
�����������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� 	 � Color$	 Black��
 � Offset$
 0Q�� $	 White��$
 1Q�m� -   $ miCLose��$��Закрыть��
����������� $ 0.5,1&�$ 0.5,0&�.��� $	 Black��$
 1Q�� $	 White��m� -   $ miHelp��$��Помощь��$
 Hand����  J� RenderTransformOrigin$ 0.504,0.718&�$��0,0,3,0q����	#FF1E2C35$
 Hand��$	��433��z�V� .~��� ��  �� AngleY$ 0.087Q� �� AngleX$ 0.003Q��� T�  T� Y$
 0.61Q� T� X$ 0.008Q�.@��� $��Меню��   tcStyle#��[  ���� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF1E2C35��$
 1Q�� $	 	#FF226E9E��.��� .+��� .+�]� .+��� $#��Тематика заказа��$��20(�
��������� -    ��Name$ 	cbSubject��$
 Hand�� �� SelectedIndex$ 0��$��30(�
���   �$	��666�� � ForceCursor . ��Z� @��� Все�� " Программирование�� +)Дискретная матемаитка�� +)Математический анализ�� !Линейная алгебра�� Информатика&   System.Windows.Controls.DataGrid  -     Name$ dgOrderTable��$	��354��$��0,0,10,0q�$	��833��   AutoGenerateColumns .     CanUserReorderColumns .     RowDetailsVisibilityMode$ Visible=�   
IsReadOnly . ���	#FF33631E���	#FF1E2C35   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Название��   
IsReadOnly .   dgStyle   	CellStyle# [ 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *NAME_SUBJECT+  $ Тематика�� . # [  �� *
NAME_ORDER+  $ Стоимость�� . # [  �� *PRICE+  $% Время выполнения�� . # [  �� *
RUN_TIME+�� $��Корзина��#��[  ���� $ 0.5,1&�$ 0.5,0&�.��� $	 	#FF1E2C35��$
 1Q�� $	 	#FF226E9E��.��]� .+��� $��Right=�.���� .+��� -    ��Name$ tbCountPainer��  lbStyle#��[ $
��Auto���� -    ��Name$ btDelete��$��Удалить��  	btStyle_1#��[ �� -    ��Name$ lbPanier��$
 Hand���� -	   $ btFormalizeOrder��$!��Оформить заказ��#��[ 