   M S B A M L   `   `   `  ����J  FFashionZoneData, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:FashionZoneData;assembly=FashionZoneDataFashionZoneData  5   	   T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   F BFashionZone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FashionZoneFashionZone 5	   	      FashionZone.Beheer   5   	   @local6clr-namespace:FashionZoneData;assembly=FashionZoneData  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   ,searchclr-namespace:FashionZone     5	   	     � Title$  Fashionzone - Shopmanager��5   	   $	��720��6+   $
��1280��68    � 
ResizeMode$ CanMinimize=�6E    � WindowStartupLocation$ Manual=�6^   
 � Top$	 200��6~    � Left$	 500��6�      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5   	    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType  MetroDataGridColumnHeader �� BasedOn	 �� Property
 �� Value  CenterCellStyle*  $System.Windows.Controls.DataGridCell  MetroDataGridCell �� 
TargetType��%B  '        7  &	 Q     7  �� 5   
   "  6   8   .�5      �� 	 � ��$
 Center=�6;   5      �� 5   
   "  6(   8   .�5      �� 	 � ��
 5      �� 5      "  6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��Center=�5   '   5      5      5      5      5      .��5      � .+�5   
   �� -   5         ��Name$ label��5      $��Zoek op:��6   $
��Left=�62   $��	64,60,0,0q�6M   $	��Top=�6`   �� 5    
   -   5         ��Name$ userControlSearchCanvas��5       $
��Left=�62   $	��100��6M   $��	64,59,0,0q�6Z   $	��Top=�6m   $	��608��6�   .+�5!      #  FashionZone.UserControlSearch  -   5          Name$ userControlSearch��5!   '   $
��Left=�6B   $	��Top=�6]   $��31��6u     5"      -   5        $ userControlSearch2��5"   '   $
��Left=�6C   $	��Top=�6^   $��31��6v   
 �� Top$ 34��6�     5#      -   5        $ userControlSearch3��5#   '   $
��Left=�6C   $	��Top=�6^   $��31��6v   $ 69��6�   5$      �� 5%   
   -   5         ��Name$ jaarTextBox��5%      $y�Hidden=�6'   $
��Left=�6;   $��23��6V   $��
126,62,0,0q�6b    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $	��130��6�   6�   �� 5&   
   -   5         ��Name$ searchButton��5&      $��30��5'      $��30��5(      $	��Top=�5)        MetroCircleButtonStyle#���  5*       � Cursor$
 Hand��6?    � ToolTip$ Doorgrond zoeken��6M   $��0q�6�    �� Left$	 778��6�   $��76,96,1168,0q�6�   .��5+      �� ���#ea4333$��15��5,      $��15��5-       J� OpacityMask 5.      !� 5/        appbar_magnify !� Visual# [ 6"   51      53      �� 54   
   -   5        $ 	addButton��54      $��30��55      $��30��56      $	��Top=�57      #���  58      $��1036,112,208,0q�65   $
 Hand��6M   $ 	Toevoegen��6[   $��0q�6�   .��59      �� ���#ea4333$��15��5:      $��15��5;       5<      !� 5=        
appbar_add# [ 6"   5?      5A      �� 5B   
   -	   5        $ removeButton��5B      $��30��5C      $��30��5D      $	��Top=�5E      #���  5F      $��1070,112,174,0q�65   $
 Hand��6M   $ Verwijderen��6[   $��0q�6�   .��5G      �� ���#ea4333$��15��5H      $��3��5I       5J      !� 5K        appbar_minus# [ 6"    j� Stretch$
 Fill=�6I   5M      5N      �� 5P   
   -
   5        $ printButton��5P      $��30��5Q      $��30��5R      $	��Top=�5S      #���  5T      $��1116,112,128,0q�65   $
 Hand��6M   $ 	Afdrukken��6[   $��0q�6�   .��5U      �� ���#ea4333$��15��5V      $��15��5W       5X      !� 5Y        appbar_printer_text# [ 6"   $
 Fill=�6P   5[      5\      �� 5]   
   -   5        $ settingsButton��5]      $��30��5^   
   $��30��5_   
   $	��Top=�5`   
   #���  5a   
   $��1151,112,93,0q�6;   $
 Hand��6R   $ Instellingen��6`   $��0q�6�   .��5b      �� ���#ea4333$��15��5c      $��15��5d       5e      !� 5f       	 appbar_settings# [	 6"   $
 Fill=�6L   5h      5i      �� 5j   
   -   5        $ resetButton��5j      $��30��5k   
   $��30��5l   
   $	��Top=�5m   
   #���  5n   
   $��76,129,1168,0q�6;   $
 Hand��6R   $ Reset zoekinstellingen��6`   $��0q�6�   .��5o      �� ���#ea4333$��15��5p      $��15��5q       5r      !� 5s       
 appbar_reset# [
 6"   $
 Fill=�6I   5u      5v      �� 5x   
   -   5         ��Name$ 
tabControl��5x      $
��Left=�6)   $��Bottom=�6D   $	��500��6_   $
��1151��6l   $��	48,0,0,39q�6y   .@�5y      �� $��
Inventaris��6   $��6,-138,-6,138q�6*   .��5z      � ���	#FFE5E5E5$��
0,15,-7,-5q�6.   .+�5{      &   System.Windows.Controls.DataGrid  -   5          Name$ inventoryDataGrid��5{         AutoGenerateColumns .  $��Center=�6V   $��Center=�6s   $	��479��6�   $
��1150��6�     AzureDataGrid#��[ 6�   $��	0,-28,0,0q�6�      CanUserAddRows .     Columns 5}      0  *System.Windows.Controls.DataGridTextColumn  5~      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 61      Header$ 
ArtikelNum��6=   1	  +System.Windows.Controls.DataGridBoundColumn  	  Binding  6Q   �� *	Artikelnr+  5      $	 205 61   $ Artikelnaam��6=     6R   �� *Artikelnaam+  5�      $ 85 61   $ 	Categorie��6<     6O   �� *	Categorie+  5�      $ 80 61   $
 Merk��6<   !   	CellStyle#! [ 6J     6w   �� *Merk+  5�      $	 100 61   $ Kleur��6=   #! [ 6L     6y   �� *Kleur+  5�      $ 70 61   $ Aantal��6<   #! [ 6L     6y   �� *Aantal+  5�      $ 70 61   $ AKPrijs��6<   #! [ 6M     6z   �� *	AKprijs+  5�      $	 100 61   $ Tot. AKPrijs��6=   #! [ 6S     6�   �� *
TotAKprijs+  5�      $ 75 61   $ VKPrijs��6<   #! [ 6M     6z   �� *	VKprijs+  5�      $	 100 61   $ Tot. VKPrijs��6=   #! [ 6S     6�   �� *
TotVKprijs+  5�      $ 80 61   $ Datum��6<   #! [ 6K     6x   �� *Datum+4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5�      $ 70 65     MetroDataGridCheckBox" 	  ElementStyle#" �  6@   # 	  EditingElementStyle## �  5�   	   $ Select��5�   	     5�   	   �� *
IsSelected+$ �� Mode$$ TwoWay=�% �� RelativeSource% �� & �� AncestorType)  #System.Windows.Controls.DataGridRow"&  5�      5�      �� 5�      -   5        $ TotAantalLabel��5�      $��	TotAantal��64   $
��Left=�6H   $��0,455,0,-34q�6c   $	��Top=�6x   $��28��6�   �� 5�      -   5        $ TotAKprijsLabel��5�      $��
TotAKPrijs��65   $
��Left=�6J   $��733,456,0,-32q�6e   $	��Top=�6|   $��25��6�   �� 5�      -   5        $ TotVKprijsLabel��5�      $��
TotVKPrijs��65   $
��Left=�6J   $��908,456,0,-32q�6e   $	��Top=�6|   $��25��6�   5�      5�      �� 5�      $��Bestellingen��6   $��16,-138,-16,138q�6,   .��5�      � ���	#FFE5E5E5$��
0,15,-7,-5q�6.   .+�5�        -   5        $ ordersDataGrid��5�       .  $
��Left=�6S   $	��Top=�6n   $	��479��6�   $
��1150��6�   '   
IsReadOnly' . $��0,-28, 0, 0q�6�    5�        5�      $ 0.125* 61   $ BonNum��6@     6P   �� *	BonNummer+  5�      $ 0.125* 61   $ Besteldatum��6@   #! [ 6U     6�   �� *BestelDatum+  5�      $ 0.125* 61   $
 Merk��6@   #! [ 6N     6{   �� *Merk+  5�      $ 0.125* 61   $ Tot. AKPrijs��6@   #! [ 6V     6�   �� *
TotAKPrijs+  5�      $ 0.125* 61   $ Tot. VKPrijs��6@   #! [ 6V     6�   �� *
TotVKPrijs+  5�      $ 0.125* 61   $ Lever Datum��6@   #! [ 6U     6�   �� *
LeverDatum+  5�      $ 0.125* 61   $ Ontvangen Op��6@   #! [ 6V     6�   �� *OntvangenOp+
  5�      $ 0.125* 65   $ 
Afgerond ?��6D   #! [ 6X     6�   �� *
Afgerond+5�      5�      5�      �� 5�      $��Totalen��6   $��26,-138,-26,138q�6'   .��5�      � $��
0,15,-7,-5q�6   .+�5�        -   5        $ maandTotalenDataGrid��5�      ' .  .  $
��Left=�6k   $	��Top=�6�   $	��479��6�   $	��533��6�   $��617,-28,0,-2q�6�   #��[ 6�    5�        5�      $ 0.25* 61   $ Maand��6?   #! [ 6N     6{   �� *Maand+  5�      $ 0.25* 61   $ Tot. Voorzien��6?   #! [ 6V     6�   �� *TotaleUitgave+  5�      $ 0.25* 61   $ Tot. Besteld��6?   #! [ 6U     6�   �� *TotaleUitgave+  5�      $ 0.25* 61   $ Betaald��6?   (   CanUserResize( .  #! [ 6f     6�   �� *Jaar+5�        5�      -   5        $ jaarTotalenDataGrid��5�      ' .  .  $
��Left=�6j   $	��Top=�6�   $	��479��6�   $	��533��6�   $��
0,-28,0,-2q�6�   #��[ 6�   )   RowHeaderTemplate) 5�      �� 5�      .R�5�   "   �� $
��Test��6,   6:   5�       5�        5�      $ 0.25* 61   $ Totalen voor 2015��6?   #! [ 6Z     6�   �� *totalenRowHeaders+  5�      $ 0.25* 61   $ Tot. Voorzien��6?   #! [ 6V     6�   �� *TotaleUitgave+  5�      $ 0.25* 61   $ Tot. Besteld��6?   #! [ 6U     6�   �� *TotaleUitgave+  5�      $ 0.20* 61   $ Betaald��6?   ( .  #! [ 6f     6�   �� *Jaar+5�      5�      5�      �� 5�      $��Klanten��6   $��36,-138,-36,138q�6'   .��5�      � $��
0,15,-7,-5q�6   .+�5�        -   5        $ klantenDataGrid��5�      $
��Left=�68   $	��Top=�6S   $	��479��6k   $
��1150��6x   $��0,-28, 0, 0q�6�   #��[ 6�    5�        5�      $
 Auto 61   $ KlantNum��6>     5�      $
 Auto 61   $ 	KlantNaam��6>     5�      $
 Auto 61   $ Adres��6>     5�      $	 100 61   $ E-Mail��6=     5�      $	 100 61   $ Telefoon��6=   5�      5�      5�      5�      5�      5�      