   M S B A M L   `   `   `  ����D  @homework3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:homework3	homework3  5   	       homework3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:homework3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� -   5         ��Name$ uxContainer��5	      .+�5
   
   �� Enter Name:6!   �� 5   
   -   5         ��Name$ uxName��5      ��5      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��.��6i   5      �� 5   
   -   5         ��Name$ uxNameError��5      ��5      �� *	NameError+$ PropertyChanged=�5      �� 5   
   Enter Password:6%   �� 5   
   -   5        $ 
uxPassword��5      ��5      �� *
Password+$ PropertyChanged=�$
 True��.��6m   5      �� 5   
   -   5        $ 	uxPwError��5      ��5      �� *	PwError+$ PropertyChanged=�5      �� 5   
   -   5         ��Name$ uxSubmit��5      {�5      �� *	IsEnabled+$ PropertyChanged=�.��6V   Submit5      5      5       