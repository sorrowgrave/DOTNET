   M S B A M L   `   `   `  ����F  BFashionZone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FashionZoneFashionZone  5   	   T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       FashionZone.Instellingen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FashionZone     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Instellingen��5	   	   $��535.5��6   $	��300��6-      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5
   	   .��5      � $��0,20,0,1q�6   .+�5   
   �� -   5         ��Name$ cancelButton��5      $��Close��6'   $
��Left=�67   $	��Top=�6R   $��76��6j   $��182,436,0,0q�6�    � Cursor$
 Hand��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ merkDataGrid��5      $
��Left=�6)   $��	23,43,0,0q�6D   $	��Top=�6W   $	��309��6o   $	��120��6|      CanUserResizeColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 105 6%      Header$
 Merk��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� *
MerkNaam+
 �� Mode$
 TwoWay=�5        5   
   -   5        $ categorieDataGrid��5      $
��Left=�6.   $��
152,43,0,0q�6I   $	��Top=�6]   $	��309��6u   $	��120��6�    .   5        5      $	 105 6%   $ 	Categorie��61   	 6D   �� *CategorieNaam+$
 TwoWay=�5      �� 5   
   -   5        $ merkAddButton��5      $��30��5   
   $��30��5   
   $	��Top=�5   
     MetroCircleButtonStyle#���  5   
   $
 Hand��6;    � ToolTip$ 	Toevoegen��6I   $��0q�6y   $��85,356,177,0q�6�   .��5      �� ���#ea4333$��15��5      $��15��5       J� OpacityMask 5      !� 5         
appbar_add !� Visual# [ 6"   5"      5$      �� 5%   
   -   5        $ merkRemoveButton��5%      $��30��5&   
   $��30��5'   
   $	��Top=�5(   
   #���  5)   
   $
 Hand��6;   $ Verwijderen��6I   $��0q�6_   $��55,356,207,0q�6s   .��5*      �� ���#ea4333$��15��5+      $��3��5,       5-      !� 5.        appbar_minus# [ 6"    j� Stretch$
 Fill=�6I   50      51      �� 52   
   -   5        $ categorieAddButton��52      $��30��53   
   $��30��54   
   $	��Top=�55   
   #���  56   
   $
 Hand��6;   $ 	Toevoegen��6I   $��0q�6~   $��212,356,50,0q�6�   .��57      �� ���#ea4333$��15��58      $��15��59       5:      !� 5;      # [ 6"   5=      5?      �� 5@   
   -   5        $ CategorieRemoveButton��5@      $��30��5A   
   $��30��5B   
   $	��Top=�5C   
   #���  5D   
   $
 Hand��6;   $ Verwijderen��6I   $��0q�6_   $��182,356,80,0q�6s   .��5E      �� ���#ea4333$��15��5F      $��3��5G       5H      !� 5I      # [ 6"   $
 Fill=�6I   5K      5L      5O      5P      