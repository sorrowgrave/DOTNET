   M S B A M L   `   `   `  ����F  BFashionZone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FashionZoneFashionZone  5   	   T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   "    FashionZone.ArtikelToevoegen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FashionZone     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Artikel Toevoegen��5	   	   $	��500��6#   $	��500��60    � 
ResizeMode$ CanMinimize=�6<      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5
   	   .��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Artikelnummer:��6   $
��Left=�68   $��	48,45,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ label1��5      $��Artikelnaam:��6    $
��Left=�67   $��	64,80,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ label2��5      $��
Categorie:��6    $
��Left=�65   $��
76,115,0,0q�6P   $	��Top=�6d   �� 5   
   -   5        $ label3��5      $��Merk:��6    $
��Left=�60   $��100,150,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ label4��5      $��Kleur:��6    $
��Left=�61   $��100,185,0,0q�6L   $	��Top=�6a   �� 5   
   -   5        $ label5��5      $��Aantal:��6    $
��Left=�62   $��
93,220,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ label6��5      $��AKPrijs:��6    $
��Left=�63   $��
91,255,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ label7��5      $��VKPrijs:��6    $
��Left=�63   $��
91,290,0,0q�6N   $	��Top=�6b   �� 5   
   -	   5        $ label8��5      $��Datum:��6    $
��Left=�61   $��
91,325,0,0q�6L   $	��Top=�6`   �� 5   
   -
   5        $ label9��5      $��
Bonnummer:��6    $
��Left=�65   $��
62,360,0,0q�6P   $	��Top=�6d   �� 5   
   -   5         ��Name$ artikelNummerTextBox��5      $
��Left=�60   $��23��6K   $��
160,46,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��181��6�   �� 5   
   -   5        $ artikelNaamTextBox��5      $
��Left=�6.   $��23��6I   $��
160,81,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��181��6�   �� 5   
   -   5        $ kleurTextBox��5      $
��Left=�6(   $��23��6C   $��160,186,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��181��6�   �� 5   
   -   5        $ aantalTextBox��5      $
��Left=�6)   $��23��6D   $��160,221,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��181��6�   �� 5   
   -   5        $ aankoopPrijsTextBox��5      $
��Left=�6/   $��23��6J   $��160,256,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��181��6�   �� 5   
   -   5        $ verkoopPrijsTextBox��5      $
��Left=�6/   $��23��6J   $��160,291,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��181��6�   �� 5   
   -   5        $ bonNummerTextBox��5      $
��Left=�6,   $��23��6G   $��160,361,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��181��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $
��Left=�6)   $��160,325,0,0q�6D   $	��Top=�6Y   $	��181��6q   �� 5   
   -   5         ��Name$ resetButton��5      $��Reset��6&   $
��Left=�66   $��236,429,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ 
saveButton��5      $
��Save��6%   $
��Left=�64   $��396,429,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5    
   -   5        $ cancelButton��5       $��Cancel��6'   $
��Left=�68   $��316,429,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5!   
   -   5         ��Name$ categorieComboBox��5!      	 �� SelectedIndex$	 0��6.   $
��Left=�6@   $��160,116,0,0q�6[   $	��Top=�6p   $	��181��6�   �� 5"   
   -   5        $ merkComboBox��5"      $	 0��6)   $
��Left=�6;   $��160,151,0,0q�6V   $	��Top=�6k   $	��181��6�   5$      5%      