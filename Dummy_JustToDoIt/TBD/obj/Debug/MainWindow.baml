   M S B A M L   `   `   `  ����>  :TBD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TBDTBD  5   	       TBD.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:TBD     5   	     � Title$  
MainWindow��5   	   $	��200��6   $	��300��6)   .��5
      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $��3* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   �� $��Center=�6   $��0��5      $��0��5      .��6$   
Task List:5      �� 5   
   -   5         ��Name$
 list��5      $��1��5      $��0��5      $��3��5      $��4q�5      ��5      �� *
allTasks+5!      �� 5"   
   -   5         ��Name$ buttonDelOne��5"      $��20��5$      $	��105��5%      $��1��5&      $��1��5'      .��6!   Delete single task5)      �� 5*   
   -   5        $ buttonDelAll��5*      $��20��5,      $	��105��5-      $��2��5.      $��1��5/      .��6!   Delete all tasks51      �� 52   
   -   5        $ 	buttonAdd��52      $��20��54      $	��105��55      $��3��56      $��1��57      .��6!   Add new task6/   �� 58   
   -   5         ��Name$ textBox��58      $��0��59      $��1��5:      $��4q�5;      5<      5=      