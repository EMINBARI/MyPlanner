   M S B A M L   `   `   `  ����D  @MyPlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyPlanner	MyPlanner  5   	       MyPlanner.AddTask   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MyPlanner     5   	     � Title$  addTask��5   	   $��451.5��6   $��473.5��6(    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L   .��5	      � ���	#FFE4E4E4$
��Left=�6"   $	��474��6=   $��0,0,0,0q�6I   .+�5
   
   �� -   5         ��Name$ nameTxt��5
      $
��Left=�6#   $
��Left=�6>   $��Center=�6`   $��40��6�   $��	61,75,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��350��6�   $��20(�6�   ���	#FFF1F1F1���	#FF0078D76�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $
��Left=�6)   $��Center=�6D   $��
61,180,0,0q�6f   $	��Top=�6z   $	��350��6�   $��40��6�   $��20(�6�   
���������6�   Z� 6�   �� 5   
   -   5         ��Name$ okBtn��5      $��Ok��6   $
��Left=�6,   $��
58,357,0,0q�6G   $	��Top=�6[   $��Center=�6s   $	��171��6�   ���	#FFF1F1F1$��20(�6�   6  �� 5   
   -   5        $ 	CancelBtn��5      $��Cancel��6#   $
��Left=�64   $��237,357,0,0q�6O   $	��Top=�6d   $��Center=�6|   $	��171��6�   ���	#FFF1F1F1���	#FF1F4DB0$��20(�6�   6+  �� 5   
   $#��Название задачи��6   $��Center=�6*   $
��Left=�6N   $��	61,43,0,0q�6i   $	��Top=�6|   $��Center=�6�   $	��350��6�   $��27��6�   ���	#FFF1F1F1$��14(�6�   �� 5   
   $��Дата��6   $��Center=�6   $
��Left=�6C   $��
61,148,0,0q�6^   $	��Top=�6r   $��Center=�6�   $	��350��6�   $��27��6�   ���	#FFF1F1F1$��14(�6�   5      5      