   M S B A M L   `   `   `  ����D  @MyPlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyPlanner	MyPlanner  5   	       MyPlanner.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MyPlanner     5   	     � Title$  	MyPlanner��5	   	   $	��650��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ CanMinimize=�6Y   .��5      � $��0,0,0,1q�6    � ColumnDefinitions 5   
   .+�5   
   �� $
��Left=�6   $	��620��6,   $	��Top=�69   $	��250��6Q    J� RenderTransformOrigin$ 0.528,0.211&�6]   $��-2,0,0,0q�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA8A8AC��6#    � Offset$ 0Q�65   � 5      $ 	#FFD8D8D8��6#   $ 1Q�65   5      .+�5      �� -   5        	 ��Name$	 todayBtn��5      $(��"  Задачи на сегодня��6&   $��Center=�6D   $��Center=�6h   $	��228��6�   $��43��6�   $��20(�6�   ���	#FFCFCFCF

 �� Top$	
 131��6	   �� Left$ 11��6  6+  �� 5      -   5        $	 
forwardBtn��5      $��Center=�6(   $��Center=�6L   $	��228��6n   $��44��6z   $��20(�6�   ���	#FFCFCFCF$	
 193��6�   $$��Задачи на завтра��6�   $ 11��6  5      �� 5      $L��FC:\Users\Computer\source\repos\MyPlanner\MyPlanner\images\calender.png��6   $��24��6d   $��24��6p   $ 17��6{   $	
 203��6�   $ 0.479,0.854&�6�   �� 5      $N��HC:\Users\Computer\source\repos\MyPlanner\MyPlanner\images\favourites.png��6   $��24��6f   $ 16��6r   $
 77��6�   $��25��6�   $��Center=�6�   $��Center=�6�    K� ZIndex$ 1��6�   �� 5      -   5        $	 allPlansBtn��5      $��Все задачи��6)   $��Center=�6>   $��Center=�6b   $	��228��6�   $��43��6�   $��20(�6�   ���	#FFCFCFCF$
 69��6	  $ 11��6  6*  �� 5      $I��CC:\Users\Computer\source\repos\MyPlanner\MyPlanner\images\today.png��6   $��24��6a   $ 15��6m   $	
 139��6~   $��25��6�   $��Center=�6�   $��Center=�6�   $ 1��6�   5       �� 5!   
   $
��Left=�6   $	��620��6,   $��
248,0,-4,0q�69   $	��Top=�6M   $	��550��6e   ���	#FFE4E4E4$��3��6�   .+�5"      �� -   5         ��Name$ 
addTaskBtn��5"      $#��Добавить задачу��6)   $ 44��6C   $
 10��6T   $	��152��6d   ���	#FF608EF1$��16(�6�   ��6p   Z� 6�   �� 5#      -   5        $ 	removeBtn��5#      $!��Удалить задачу��6(   $	 201��6A   $
 10��6S   $	��152��6c   ���	#FFF16060$��16(�6�   ��6o   Z� 6�   �� 5$      -   5        $ editBtn��5$      $ ��Редактировать��6&   $	 358��6>   $
 10��6P   $	��152��6`   ���	#FFF1AF60$��16(�6�   ��6l   Z� 6�   �� 5%      -   5         ��Name$ listBoxMain��5%      ���	#FFE4E4E4$	��515��6B   $
 68��6O   $	��545��6_   $ 2��6k   $��25(�6{   �� 5&      -   5        $	 noTasksLabel��5&      $y�Hidden=�6*   $	��320��6>   $��50��6J   $0��*Пока нет текущих задач!��6V   $��20(�6x   $��Center=�6�   $��Center=�6�   $��Center=�6�   $	 113��6�   $	
 262��6�   6  5'      5)      5+      