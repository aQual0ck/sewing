   M S B A M L   `   `   `  ����A  =sewing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:sewing.Pagessewing.Pages  5      !    sewing.Pages.PageEditFabric   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:sewing.Pages     5        N� Title$  PageEditFabric��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $	��430 �6   .+�5   
   o� $��0��6   $��Center=�6   .@�5      m� -   5        $��menuBack��5      $��
Назад��6'   66   m� 5      -   5        $��menuCutting��5      $��Раскрой��6*   6;   5      �� 5   
   $	��350��6   $	��325��6    
����������#666666$��1��5      �� 5   
   $��Center=�6   $��Center=�62   $��1��5      .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Артикул:��6   $	��150��6,   �� 5      -   5        $��txbItemNumber��5      $	��150��6/   $��
5, 5, 0, 5q�6;   ��5      �� *
ItemNumber+5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Наименование:��6   $	��150��61   �� 5       -   5        $��txbProductName��5       $	��150��60   $��
5, 5, 0, 5q�6<   ��5!      �� *ProductName+5"      �� 5#      $ 
Horizontal=�6   .+�5$      �� $��	Цвет:��6   $	��150��6)   �� 5%      -   5        $��txbColor��5%      $	��150��6*   $��
5, 5, 0, 5q�66   ��5&      �� *Color+5'      �� 5(      $ 
Horizontal=�6   .+�5)      �� $��	Узор:��6   $	��150��6)   �� 5*      -   5        $��
txbPattern��5*      $	��150��6,   $��
5, 5, 0, 5q�68   ��5+      �� *	Pattern+5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��Состав:��6   $	��150��6+   �� 5/      -   5        $��txbComposition��5/      $	��150��60   $��
5, 5, 0, 5q�6<   ��50      �� *Composition+51      �� 52      $ 
Horizontal=�6   .+�53      �� $��Ширина:��6   $	��150��6+   �� 54      -   5        $��txbWidth��54      $	��150��6*   $��
5, 5, 0, 5q�66   ��55      �� *Width+56      �� 57      $ 
Horizontal=�6   .+�58      �� $��Длина:��6   $	��150��6*   �� 59      -	   5        $��	txbLength��59      $	��150��6+   $��
5, 5, 0, 5q�67   ��5:      �� *Length+5;      �� 5<      $ 
Horizontal=�6   .+�5=      �� $��	Цена:��6   $	��150��6)   �� 5>      -
   5        $��txbPrice��5>      $	��150��6*   $��
5, 5, 0, 5q�66   ��5?      �� *Price+5@      �� 5A      -   5        $��btnSave��5A      $��Сохранить��6$    � 	Resources 5B       �� 
TargetType �� Property �� Value��%^   '��       �� 5C      " ��6   .�5D      ��  �@��CornerRadius$ 7��69   5E      5F      5G      5H      5I      5J      