   M S B A M L   `   `   `  ����O  KВисельница, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ВисельницаВисельница  5   	   O,clr-namespace:Висельница.ViewModelВисельница.ViewModel  5   	   %    Висельница.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Висельница     5   	   ;vm,clr-namespace:Висельница.ViewModel     5   	     � Title$  Висельица��5	   	   $	��450��6   $	��800��6(    � 	Resources 5
         characterBox �� DataType  Storyboard1��%�   &	        &	 �     �� 5   
   $ ListBoxItem��6,   .R�5      �� $��5q�61   $��15(�6=   ��6   �� *	Character+{�6K   �� *	Unknown+5      �� 5   
   6   5      ��5      �� 5   
    �� ImageSource$V P/depositphotos_190272036-stock-illustration-tetrad-cell-notebook-cage-vector.jpg��6    � DataContext 5      +   %Висельница.ViewModel.MainVM  5   
   .��5      � '  !System.Windows.VisualStateManager   VisualStateGroups 5   
   %  System.Windows.VisualStateGroup  5      -   5        VisualStateGroup��5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Center=�60   $��Uniform=�6M   ��6   �� *CurrentImage+6M   �� 5    
   #��[  6   $��1��6?   $��Center=�6L   ��6i   �� *	TryWord+��5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6!   5$      5&      �� 5'   
   $��Center=�6   $ 
Horizontal=�62   $��2��6K   .+�5(      �� $��5q�6   $��15(�6"   $��Center=�60    �� 	MaxLength$ 2��6j   ��6M   �� *CountLetter+6j   �� 5)      $��Начать игру��6   ��6+   �� *CommandStart+��5*      �� 5+      	 �� EndPoint$	 0.5,1&�6*   
 �� 
StartPoint$
 0.5,0&�6;   .��5,      �  � Color$ 	#FF6B9BE0��6'   � 5-      $ 	#FFC9F589��6'    � Offset$ 1Q�69   5.      50      �� 51      $��Угaдать букву��6   ��6-   �� *
CommandTry+��52      �� 53      $	 0.5,1&�6*   $
 0.5,0&�6;   .��54      � $ 	#FF8EAFF5��6'   $ 0.351Q�69   � 55      $ 	#FF013097��6'   $ 1Q�69   56      58      59      �� 5:   
   ��6   �� *	Message+ �� Mode$ OneWay=�5;      5<      