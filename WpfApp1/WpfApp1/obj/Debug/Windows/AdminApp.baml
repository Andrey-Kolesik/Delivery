   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1.WindowsWpfApp1.Windows  5   	       WpfApp1.Windows.AdminApp   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp1.Windows     5   	   -   5          � Title$  AdminApp��5      $	��600��6   $	��800��6&    � Icon$ /Images/logo.png��62   ���#E6DA76
 � Top$	 120��6_    � Left$ 50��6i    � WindowStartupLocation$ CenterScreen=�6s   .��5	      �  J� RenderTransformOrigin$ 0.562,0.447&�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
myDataGrid��5
         AutoGenerateColumns .  $	��270��6\   $
��Left=�6h   ���	#FFF5E346$��10q�6�   $��15(�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 RestId��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *RestId+  5      $	 RestName��6%   
 67   �� *
RestName+  5      $	 
RestSourse��6%      MaxWidth$	 100Q�6X   
 69   �� *
RestSourse+6X   5      �� 5   
   -   5        $	��Add��5      $
��Left=�6   $��310,139,0,0q�6:   $	��Top=�6O   $	��100��6g   $ -0.112,-0.597&�6s   $��40��6�   
���   �$��Century Gothic)�6�   $
��Bold"�6�   $��18(�6  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ White��6#   � 5      $ 	#FFE6B7B7��6#    � Offset$ 0.794Q�65   � 5      $ 	#FFCB1212��6#   5      5      �� 5   
   -   5         ��Name$ IdText��5      $
��Left=�6"   $��45��6=   $��
443,10,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��148��6�   �� 5   
   -   5        $ NameText��5      $
��Left=�6$   $��45��6?   $��
443,60,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��148��6�   �� 5   
   -   5        $��Delete��5      $
��Left=�6"   $��425,139,0,0q�6=   $	��Top=�6R   $	��100��6j   $��40��6v   
���   �$��Century Gothic)�6�   $
��Bold"�6�   $��18(�6�   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ White��6#   � 5       $ 	#FFE6B7B7��6#   $ 0.794Q�65   � 5!      $ 	#FFCB1212��6#   5"      5$      �� 5%   
   -   5        $��Insert��5%      $
��Left=�6"   $��541,139,0,0q�6=   $	��Top=�6R   $	��100��6j   $��40��6v   
���   �$��Century Gothic)�6�   $
��Bold"�6�   $��18(�6�   ��5&      �� 5'      $ 0.5,1&�6&   $ 0.5,0&�67   .��5(      � $ White��6#   � 5)      $ 	#FFE6B7B7��6#   $ 0.794Q�65   � 5*      $ 	#FFCB1212��6#   5+      5-      �� 5.   
   -   5        $��Image��5.      $
��Left=�6!   $��656,139,0,0q�6<   $	��Top=�6Q   $	��100��6i   $��40��6�   
���   �$��Century Gothic)�6�   $
��Bold"�6�   $��18(�6�   ��5/      �� 50      $ 0.5,1&�6&   $ 0.5,0&�67   .��51      � $ White��6#   � 52      $ 	#FFE6B7B7��6#   $ 0.794Q�65   � 53      $ 	#FFCB1212��6#   54      56      �� 57   
   $��RestId��6   $
��Left=�6!   $��
355,10,0,0q�6<   $	��Top=�6P   $��25(�6h   �� 58   
   $��RestName��6   $
��Left=�6#   $��
310,60,0,0q�6>   $	��Top=�6R   $��25(�6j   $ 0.358,0.488&�6x   59      5;      