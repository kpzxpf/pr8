   M S B A M L   `   `   `  ����>  :Pr8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Pr8Pr8  5   	       Pr8.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:Pr8     5   	     � Title$  Главное окно��5   	   $	��450��6   $	��600��6+    � WindowStartupLocation$ CenterScreen=�67   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UsersDataGrid��5         AutoGenerateColumns$ False��6*      SelectionMode$ Single=�6F      
IsReadOnly$
 True��5      $��0��6%      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 6H   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *id+6H     5      $ Фамилия��6%   $		 150 6T   
 66   �� *	last_name+6T     5      $ Имя��6%   $		 150 6Q   
 62   �� *
first_name+6Q     5      $ Email��6%   $		 200 6N   
 64   �� *email+6N   5      �� 5   
   -   5         ��Name$ ViewPurchaseHistoryButton��5      $#��История покупок��64   $��30��5      $	��200��6   $��0,10,0,0q�6)   $��1��6;   $��Center=�5      5      5      5      