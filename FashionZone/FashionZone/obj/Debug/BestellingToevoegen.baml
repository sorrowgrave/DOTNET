   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BFashionZone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FashionZoneFashionZone 5   	   %   FashionZone.BestellingToevoegen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:FashionZone     5   	     � Title$  Bestelling Toevoegen��5
   	   $	��275��6&   $	��500��63    � 
ResizeMode$ CanMinimize=�6?      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5   	   .��5      � $	��500��6   $	��275��6   .+�5   
   �� -   5         ��Name$ label��5      $��Bon Nummer:��6   $
��Left=�65   $��	49,35,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ label1��5      $��Besteldatum:��6    $
��Left=�67   $��	54,66,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ label2��5      $��Merk:��6    $
��Left=�60   $��
93,101,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label3��5      $��Leverdatum:��6    $
��Left=�66   $��
58,136,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5         ��Name$ bonNummerTextBox��5      $
��Left=�6,   $��23��6G   $��
167,35,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��181��6�   �� 5   
   -   5         ��Name$ merkComboBox��5      $
��Left=�6)   $��167,101,0,0q�6D   $	��Top=�6Y   $	��181��6q   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ bestelDatePicker��5      $
��Left=�6/   $��
167,66,0,0q�6J   $	��Top=�6^   $	��181��6v     5   
   -   5        $ leverDatePicker��5      $
��Left=�6.   $��167,136,0,0q�6I   $	��Top=�6^   $	��181��6v   �� 5   
   -	   5         ��Name$ 
saveButton��5      $
��Save��6%   $
��Left=�64   $	��Top=�6O   $��75��6g   $��396,206,0,0q�6r   	 � Cursor$
	 Hand��6�   6�   �� 5   
   -
   5        $ cancelButton��5      $��Cancel��6'   $
��Left=�68   $	��Top=�6S   $��75��6k   $��316,206,0,0q�6�   $
	 Hand��6�   5      5      