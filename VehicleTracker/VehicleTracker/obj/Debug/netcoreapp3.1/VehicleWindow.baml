   M S B A M L   `   `   `  ����I  EVehicleTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:VehicleTrackerVehicleTracker  5   	   "    VehicleTracker.VehicleWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:VehicleTracker     5   	   -   5          � Title$  VehicleWindow��5   	   $	��450��6   $	��800��6,    +� FocusedElement 5	   	   ��  �� ElementName$ uxMake��.��5      � -   5         �Name$ uxGrid��5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��1* �6   �� 5      $��50 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6$   $��Right=�61   Make:6T   �� 5   
    �� Orientation$ Vertical=�6   $��0��6,   $��1��69   .+�5      �� -   5         ��Name$ uxMake��5      ��6&   �� *Make+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� ValidatesOnDataErrors$
	 True��6   �� 5      -   5        
 ��Name$
 uxMakeError��5      ��6-   �� *	MakeError+$ PropertyChanged=�6o   5      �� 5    
   $��0��6   $��1��6$   $��Right=�61   Model:6U   �� 5!   
   $ Vertical=�6   $��1��6,   $��1��69   .+�5"      �� -   5        $ uxModel��5"      ��6'   �� *Model+$ PropertyChanged=�$
	 True��6�   �� 5#      -   5        $
 uxModelError��5#      ��6.   �� *
ModelError+$ PropertyChanged=�6q   5$      �� 5&   
   $��0��6   $��2��6$   $��Right=�61   Year:6T   �� 5'   
   -   5         ��Name$ uxYear��5'      $��1��68   $��2��6H    � Minimum$
 1990Q�6U    � Maximum$
 2025Q�6d    �� TickPlacement$ BottomRight=�6s    �� TickFrequency$ 1Q�6�    �� IsSnapToTickEnabled$
 True��6�    � Value 6!   �� *Year+6�   �� 5(   
   $��2��6   $��2��6"   ��6/   �� $ uxYear�� �� Path$ Value�$ 	LostFocus=��� 5*   
   $��0��6   $��3��6$   $��Right=�61   
Mileage:6W   �� 5+   
   -   5        $ 	uxMileage��5+      $��1��6>   $��3��6N   $ 200000Q�6[   $ BottomRight=�6l   $	 500Q�6�   $
 True��6�    6$   �� *	Mileage+6�   �� 5,   
   $��2��6   $��3��6"   ��6/   �� $ 	uxMileage��$ Value�$ 	LostFocus=��� 5.   
   $��0��6   $��4��6$   $��Right=�61   Color:6U   �� 5/   
   $ Vertical=�6   $��4��6,   $��1��69   .+�50      �� -	   5        $ uxColor��50      ��6'   �� *Color+$ PropertyChanged=�$
	 True��6�   �� 51      -
   5        $
 uxColorError��51      ��6.   �� *
ColorError+$ PropertyChanged=�6q   52      �� 54   
   $ 
Horizontal=�6   $��1��6.   $��5��6>   $��Right=�6K   .+�55      �� -   5         ��Name$ uxSubmit��55      $��10��6(   $��Center=�66   $��10q�6j   {�6v   �� *	IsEnabled+$ PropertyChanged=�.��6�   Add6�   �� 56      -   5        $ uxCancel��56      $��10��6(   $��Center=�66   $��10q�6j   .��6v   Cancel6~   57      58      59      