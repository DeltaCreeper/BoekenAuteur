   M S B A M L   `   `   `  ����S  OBoekenAuteurs3LagenModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BoekenAuteurs3LagenModelBoekenAuteurs3LagenModel  5   	   )    #BoekenAuteurs3LagenModel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:BoekenAuteurs3LagenModel     5   	     � Title$  Zoek en��5   	   $��477.24��6   $��813.75��6)   .��5	      � $��0,0,27.4,14.8q�6   .+�5
   
   �� -   5         ��Name$ TermTextBlock��5
      $
��Left=�6+   $��	30,63,0,0q�6F   $
��Wrap=�6Y   $��Geef je term in: ��6m   $	��Top=�6�   �� 5   
   -   5         ��Name$ TermTextBox��5      $
��Left=�6'   $��23��6B   $��
173,56,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��263��6�   �� 5   
   -   5         ��Name$ 
zoekButton��5      $
��Zoek��6%   $
��Left=�64   $��
525,56,0,0q�6O   $	��Top=�6c   $��75��6{   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ boekenDataGrid��5         AutoGenerateColumns .  $
��Left=�6_   $��
30,149,0,0q�6z   $	��Top=�6�   $	��207��6�   $	��686��6�      
IsReadOnly . ��6G   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        
iSBNColumn��,  &System.Windows.Controls.DataGridColumn	   Header$
	 ISBN��5   R   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToCells 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *ISBN+6`     5      -   5        titelColumn��$	 Titel��5   T   $
 SizeToCells 6c    6:   �� *Titel+6c     5      -   5        auteurColumn��$	 Auteur��5   V   $
 SizeToCells 6f    6;   �� *Auteur+6f     5      -   5        paginasColumn��$	 Paginas��5   X   $
 SizeToHeader 6i    6<   �� *	Paginas+6i     5      -	   5        genreColumn��$	 Genre��5   T   $
 SizeToCells 6c    6:   �� *Genre+6c   5      5      5      