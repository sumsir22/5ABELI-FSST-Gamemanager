   M S B A M L   `   `   `  ����R  N5ABELI_FSST_Gamemanager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:_5ABELI_FSST_Gamemanager_5ABELI_FSST_Gamemanager  5   	   )    #_5ABELI_FSST_Gamemanager.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:_5ABELI_FSST_Gamemanager     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ btn_add��5
      $	��Add��6"   $
��Left=�60   $��52��6K   $��
44,244,0,0q�6W   $	��Top=�6k   $	��133��6�   6�   �� 5   
   -   5        $ 
btn_delete��5      $��Delete��6%   $
��Left=�66   $��53��6Q   $��
44,301,0,0q�6]   $	��Top=�6q   $	��133��6�   6�   �� 5   
   -   5        $ btn_new_game��5      $	��New��6'   $
��Left=�65   $��53��6P   $��	44,70,0,0q�6\   $	��Top=�6o   $	��133��6�   6�   �� 5   
   -   5        $ btn_open_list��5      $
��Open��6(   $
��Left=�67   $��53��6R   $��
44,128,0,0q�6^   $	��Top=�6r   $	��133��6�   6�   �� 5   
   -   5         ��Name$ listview_games��5      $
��Left=�6+   $	��355��6F   $��	203,0,0,0q�6S   $��Center=�6f   $	��574��6�    �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$	 100��6Y    �� DisplayMemberBinding 63   �� *name+6Y   �� 5      $��Genre��6%   $	 100��6[    64   �� *genre+6[   �� 5      $
��Date��6%   $	 100��6Y    63   �� *date+6Y   5      5      �� 5   
   -   5         ��Name$ lbl_current_file��5      $�� ��6*   $
��Left=�65   $��32��6P   $��	44,56,0,0q�6\   $	��Top=�6o   $	��114��6�   �� 5   
   -   5        $ btn_save_list��5      $
��Save��6(   $
��Left=�67   $��53��6R   $��
44,186,0,0q�6^   $	��Top=�6r   $	��133��6�   6�   5      5      