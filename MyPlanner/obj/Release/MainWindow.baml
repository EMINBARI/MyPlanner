   M S B A M L   `   `   `  ���� D  @MyPlanner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MyPlanner	MyPlanner      MyPlanner.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:MyPlanner       � Title$  	MyPlanner��$	��650��$	��800�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=�.��� $��0,0,0,1q� � ColumnDefinitions .+��� $
��Left=�$	��620��$	��Top=�$	��250�� J� RenderTransformOrigin$ 0.528,0.211&�$��-2,0,0,0q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFA8A8AC�� � Offset$ 0Q�� $ 	#FFD8D8D8��$ 1Q�.+��� -   	 ��Name$	 todayBtn��$(��"  Задачи на сегодня��$��Center=�$��Center=�$	��228��$��43��$��20(����	#FFCFCFCF

 �� Top$	
 131�� �� Left$ 11���� -   $	 
forwardBtn��$��Center=�$��Center=�$	��228��$��44��$��20(����	#FFCFCFCF$	
 193��$$��Задачи на завтра��$ 11���� $L��FC:\Users\Computer\source\repos\MyPlanner\MyPlanner\images\calender.png��$��24��$��24��$ 17��$	
 203��$ 0.479,0.854&��� $N��HC:\Users\Computer\source\repos\MyPlanner\MyPlanner\images\favourites.png��$��24��$ 16��$
 77��$��25��$��Center=�$��Center=� K� ZIndex$ 1���� -   $	 allPlansBtn��$��Все задачи��$��Center=�$��Center=�$	��228��$��43��$��20(����	#FFCFCFCF$
 69��$ 11���� $I��CC:\Users\Computer\source\repos\MyPlanner\MyPlanner\images\today.png��$��24��$ 15��$	
 139��$��25��$��Center=�$��Center=�$ 1���� $
��Left=�$	��620��$��
248,0,-4,0q�$	��Top=�$	��550�����	#FFE4E4E4$��3��.+��� -    ��Name$ 
addTaskBtn��$#��Добавить задачу��$ 44��$
 10��$	��152�����	#FF608EF1$��16(���Z� �� -   $ 	removeBtn��$!��Удалить задачу��$	 201��$
 10��$	��152�����	#FFF16060$��16(���Z� �� -   $ editBtn��$ ��Редактировать��$	 358��$
 10��$	��152�����	#FFF1AF60$��16(���Z� �� -    ��Name$ listBoxMain�����	#FFE4E4E4$	��515��$
 68��$	��545��$ 2��$��25(��� -   $	 noTasksLabel��$y�Hidden=�$	��320��$��50��$0��*Пока нет текущих задач!��$��20(�$��Center=�$��Center=�$��Center=�$	 113��$	
 262��