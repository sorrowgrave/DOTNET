   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BFashionZone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FashionZoneFashionZone 5   	   %   FashionZone.BestellingAanpassen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:FashionZone     5   	     � Title$  BestellingAanpassen��5	   	   $	��720��6%   $
��1280��62      AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5
   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ artikelsDataGrid��5         CanUserAddRows .  $
��Left=�6D   $	��Top=�6_   $	��325��6w   $
��1162��6�     AzureDataGrid#��[ 6�   $��
58,232,0,0q�6�      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6%      Header$ 
ArtikelNum��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *	Artikelnr+	 �� Mode$	 TwoWay=�  5      $	 200 6%   $ Artikelnaam��61    6F   �� *Artikelnaam+$	 TwoWay=�  5      $ 90 6%   $ 	Categorie��60    6C   �� *	Categorie+$	 TwoWay=�  5      $	 100 6%   $
 Merk��61    6?   �� *Merk+$	 TwoWay=�  5      $	 100 6%   $ Kleur��61    6@   �� *Kleur+$	 TwoWay=�  5      $
 Auto 6%   $ Aantal��62    6B   �� *Aantal+$	 TwoWay=�  5      $
 Auto 6%   $ AKPrijs��62    6C   �� *	AKprijs+$	 TwoWay=�  5      $	 100 6%   $ Tot. AKPrijs��61    6G   �� *
TotAKprijs+$	 TwoWay=�  5      $ 75 6%   $ VKPrijs��60    6A   �� *	VKprijs+$	 TwoWay=�  5      $	 100 6%   $ Tot. VKPrijs��61    6G   �� *
TotVKprijs+$	 TwoWay=�  5      $ 70 6%   $ Datum��60    6?   �� *Datum+$	 TwoWay=�4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ 95 6)     MetroDataGridCheckBox
   ElementStyle#
 �  64      EditingElementStyle# �  5      $ Afgerond��5       5      �� *
Afgerond+$	 TwoWay=�   	CellStyle 5      �� 5      .�5       -   5        5!      5#      5&      �� 5'   
   -   5         ��Name$ label��5'      $��Bon Nummer:��6   $
��Left=�65   $��	49,47,0,0q�6P   $	��Top=�6c   �� 5(   
   -   5        $ label1��5(      $��Besteldatum:��6    $
��Left=�67   $��	54,78,0,0q�6R   $	��Top=�6e   �� 5)   
   -   5        $ label2��5)      $��Merk:��6    $
��Left=�60   $��
93,113,0,0q�6K   $	��Top=�6_   �� 5*   
   -   5        $ label3��5*      $��Leverdatum:��6    $
��Left=�66   $��
58,148,0,0q�6Q   $	��Top=�6e   �� 5+   
   -   5         ��Name$ bonNummerTextBox��5+      $
��Left=�6,   $��23��6G   $��
167,47,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��181��6�   �� 5,   
   -   5         ��Name$ merkComboBox��5,      $
��Left=�6)   $��167,113,0,0q�6D   $	��Top=�6Y   $	��181��6q   (  "System.Windows.Controls.DatePicker  5-   
   -	   5          Name$ bestelDatePicker��5-      $
��Left=�6/   $��
167,78,0,0q�6J   $	��Top=�6^   $	��181��6v     5.   
   -
   5        $ leverDatePicker��5.      $
��Left=�6/   $��167,148,0,0q�6J   $	��Top=�6_   $	��181��6w   �� 5/   
   -   5         ��Name$ 	addButton��5/      $��30��50   
   $��30��51   
   $	��Top=�52   
     MetroCircleButtonStyle#���  53   
   $��1094,170,148,0q�6;    � Cursor$
 Hand��6S    � ToolTip$ 	Toevoegen��6a   $��0q�6�   .��54      �� ���#ea4333$��15��55      $��15��56       J� OpacityMask 57      !� 58        
appbar_add !� Visual# [ 6"   5:      5<      �� 5=   
   -   5        $ removeButton��5=      $��30��5>   
   $��30��5?   
   $	��Top=�5@   
   #���  5A   
   $��1128,170,114,0q�6;   $
 Hand��6S   $ Verwijderen��6a   $��0q�6�   .��5B      �� ���#ea4333$��15��5C      $��3��5D       5E      !� 5F        appbar_minus# [ 6"    j� Stretch$
 Fill=�6I   5H      5I      �� 5J   
   -   5        $ printButton��5J      $��30��5K   
   $��30��5L   
   $	��Top=�5M   
   #���  5N   
   $��1160,170,82,0q�6;   $
 Hand��6R   $ 	Afdrukken��6`   $��0q�6�   .��5O      �� ���#ea4333$��15��5P      $��15��5Q       5R      !� 5S        appbar_printer_text# [ 6"   $
 Fill=�6P   5U      5V      �� 5W   
   -   5        $ 
saveButton��5W      $
��Save��6%   $
��Left=�64   $	��Top=�6O   $��75��6g   $��1163,632,0,0q�6r   $
 Hand��6�   6�   �� 5X   
   -   5        $ cancelButton��5X      $��Cancel��6'   $
��Left=�68   $	��Top=�6S   $��75��6k   $��1083,632,0,0q�6�   $
 Hand��6�   �� 5Y   
   -   5        $ aantalLabel��5Y      $��Aantal��6%   $
��Left=�66   $��
58,610,0,0q�6Q   $	��Top=�6e   �� 5Z   
   -   5        $ 
totAKPrijs��5Z      $��
totAKPrijs��6$   $
��Left=�69   $��790,610,0,0q�6T   $	��Top=�6i   �� 5[   
   -   5        $ 
totVKPrijs��5[      $��
totVKPrijs��6$   $
��Left=�69   $��976,610,0,0q�6T   $	��Top=�6i   5]      5^      