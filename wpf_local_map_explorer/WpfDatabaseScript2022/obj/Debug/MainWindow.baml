   M S B A M L   `   `   `  ����P  LWpfDatabaseScript2022, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfDatabaseScript2022WpfDatabaseScript2022  5   	   &     WpfDatabaseScript2022.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfDatabaseScript2022     5   	     � Title$  Podróżnik po Polsce��5   	   $
��1000��6%   $
��1500��63    � WindowStyle$ SingleBorderWindow=�5	   	    � 
ResizeMode$ NoResize=�6*    � WindowStartupLocation$ CenterScreen=�6@   .��5      �  J� RenderTransformOrigin$ 0.498,0.477&�6   .+�5   
   �� $��Województwo:��6   $
��Left=�6'   $��1007,626,0,0q�6B   $	��Top=�6X   $	��183��6p   $��44��6|   $��24(�6�   �� 5   
   -   5         ��Name$ 
WojTextBox��5      $
��Left=�6&   $��32��6A   $��1196,631,0,0q�6M    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��250��6�   $��18(�6�   
�������6�   �� 5   
   $��Miasto:��6   $
��Left=�6"   $��1007,675,0,0q�6=   $	��Top=�6S   $	��103��6k   $��36��6w   $��24(�6�   �� 5   
   -   5        $ MiastoTextBox��5      $
��Left=�6)   $��32��6D   $��1196,680,0,0q�6P   $
 Wrap=�6f   $	��Top=�6z   $	��250��6�   $��18(�6�   
�������6�   �� 5   
   $��Nazwa Miejsca:��6   $
��Left=�6)   $��1007,723,0,0q�6D   $	��Top=�6Z   $	��191��6r   $��36��6~   $��24(�6�   �� 5   
   -   5        $ NazwaMiejscaTextBox��5      $
��Left=�6/   $��32��6J   $��1196,728,0,0q�6V   $
 Wrap=�6l   $	��Top=�6�   $	��250��6�   $��18(�6�   
�������6�   �� 5   
   $��Opis Miejsca:��6   $
��Left=�6(   $��1007,772,0,0q�6C   $	��Top=�6Y   $	��166��6q   $��45��6}   $��24(�6�   �� 5   
   -   5        $ OpisMiejscaTextBox��5      $
��Left=�6.   $��31��6I   $��1196,777,0,0q�6U   $
 Wrap=�6k   $	��Top=�6   $	��250��6�   $��18(�6�   
�������6�   �� 5   
   $��Lokalizacja:��6   $
��Left=�6'   $��1007,817,0,0q�6B   $	��Top=�6X   $	��166��6p   $��45��6|   $��24(�6�   �� 5   
   -   5        $ LokalizacjaTextBox��5      $
��Left=�6.   $��31��6I   $��1196,824,0,0q�6U   $
 Wrap=�6k   $	��Top=�6   $	��250��6�   $��18(�6�   
�������6�   �� 5   
   -   5         ��Name$ 	addButton��5      $��Dodaj Rekordy��6$   $
��Left=�6<   $��1050,882,0,0q�6W   $	��Top=�6m   $	��366��6�   $��60��6�   $��36(�6�   �� 5!   
   -   5         ��Name$ comboBoxWojewodztwa��5!      $
��Left=�60   $��1020,107,0,0q�6K   $	��Top=�6a   $	��426��6y   	 �� Text$	 Opolskie��6�   $��35��6�   $��18(�6�   .@�5"      �� .��6   
Opolskie6%   �� 5#      .��6   	Slaskie6$   �� 5$      .��6   Mazowieckie6(   �� 5%      .��6   Malopolskie6(   �� 5&      .��6   Podkarpackie6)   �� 5'      .��6   
Lubeskie6%   �� 5(      .��6   Swietokrzyskie6+   �� 5)      .��6   	Lodzkie6$   �� 5*      .��6   Dolnoslaskie6)   �� 5+      .��6   Wielkopolskie6*   �� 5,      .��6   
Lubuskie6%   �� 5-      .��6   	Podlaskie6&   �� 5.      .��6   Kujawsko-pomorskie6/   �� 5/      .��6   Warmińsko-Mazurskie60   �� 50      .��6   	Pomorskie6&   �� 51      .��6   Zachodniopomorskie6/   53      �� 54   
   -   5        $ comboBoxMiasta��54      $
��Left=�6+   $��1020,234,0,0q�6F   $	��Top=�6\   $	��426��6t   $��35��6�   $��18(�6�   56      �� 57   
   $��Wybierz Województwo:��6   $
��Left=�6/   $��1020,23,0,0q�6J   $	��Top=�6_   $��84��6w   $	��434��6�   $��36(�6�   �� 58   
   $��Wybierz Miasto:��6   $
��Left=�6*   $��1020,159,0,0q�6E   $	��Top=�6[   $��84��6s   $	��308��6   $��36(�6�   (  "System.Windows.Controls.WebBrowser  59   
   -	   5        
  Name$
 
webBrowser��59      $��
0,0,530,10q�6)   �� 5:   
   -
   5         ��Name$ listView��5:   @   $��1019,300,46,382q�6R   $��22(�6k   
������� �� View 5;      �� 5<      .P�5=      �� $��Nazwa miejsca��6%    �� DisplayMemberBinding 6<   �� *nazwa_miejsca+5?      5A      5C      5D      