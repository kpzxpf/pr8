   M S B A M L   `   `   `  ����>  :Pr8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Pr8Pr8  5   	       Pr8.PurchaseHistory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   #localclr-namespace:Pr8     5   	     � Title$#  История покупок��5   	   $	��450��6!   $	��600��6.   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��0��5      $	��200��6    $��0,0,0,10q�6,   ��5      �� *
Categories+ �� SelectedItem 5      �� *SelectedCategory+ �� Mode$ TwoWay=�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PurchasesGrid��5      $��1��5         AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Название товара��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6_   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� *product_name+6_     5      $ Категория��6%   $		 150 6U   
 68   �� *
category+6U     5      $ Цена��6%   $		 100 6c   
 63   �� *price+ �� StringFormat$ {0:C}��6c     5      $ Дата покупки��6%   $		 150 6|   
 6;   �� *purchase_date+$ {0:dd.MM.yyyy}��6|   5      5       5!      