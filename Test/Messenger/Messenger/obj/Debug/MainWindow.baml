   M S B A M L   `   `   `  ����D  @Messenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Messenger	Messenger  5   	       Messenger.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Messenger     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��326��6)    � 	Resources 5
         listboxtemplate��%X  &	        �� 5   
   .R�5      �� $��3q�6   .+�5      ]� .+�5      �� $
��Bold"�6    $
��Left=�5      $��5,0,10,0q�6/   ��5   2   �� *Sender+5   /   �� 5      $��  ��6    �� 5      
��� � �$
��Bold"�6P   ��6    �� *ContactName+6P   5      ]� 5      .+�5      �� $
��Bold"�6    
��� ���$
��Left=�5      $��5,0,5,0q�6/   ��5   2   �� *MessageString+5   /   �� 5      $��  ��6    �� 5      ��6    �� *Sender+�� 5      $��  ��6    �� 5      ��6    �� *
Receiver+5      5      5!      5"      .��5$      �  � ColumnDefinitions 5%   
   �� 5&      $
��386* �6   �� 5'      $
��131* �6    � RowDefinitions 5*   
   �� 5+      $	��74* �6   �� 5,      $
��191* �6   �� 5-      $	��55* �6   .+�5/   
   �� -   5        $��Btn_Send��5/      $
��Send��6!   $��1��60   $��2��6@   $	�� 10q�6M   6Z   �� 50   
   -   5        $��Tbx_Message��50      $��2��6%   $��10q�62   �� 51   
   $��1��6   $��5q�6"    J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         	Direction$
 -150Q�6#      Color$ Black��64      ShadowDepth$ 2Q�6B   .+�55      �� -   5        $��LB_Messages��55      $
��Auto��6*   $��5q�68   #��[  6C   56      �� 57   
   -   5        $��Tbx_Receiver��57      $��	Recipient��6&   $��20q�67   �� 58   
   -   5        $��Tbx_LoggeInUser��58      $
��User��6)   $��1��65   $��20q�6E   $��Center=�6Q   $��Center=�6s   59      5:      