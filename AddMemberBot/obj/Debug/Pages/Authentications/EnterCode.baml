   M S B A M L   `   `   `  ����  AddMemberBot2    ,AddMemberBot.Pages.Authentications.EnterCode   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� 
Background
  ����  N� 
FontFamily$7 1/AddMemberBot;component/Fonts/vazir/#Vazir FD-WOL)�5	       N� Title$ 	EnterCode��5
       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value   InputBox 
 bounce �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  '��       &	  �    &	 �    �� 5   
   " ��6   .�5      ��  � ��$
 40px��6'   �� 5       � ��$ 100px��6&   �� 5       � ��$ 15(�6)   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��
 �   �6+   �� 5       � ��
 �����6+   �� 5       � ��$ 5q�60   �� 5       � ��
 �  ��6,   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5      P� 5       	 �@J�IsMouseOver
 . . �5!      ��  � �� �	#FF36353563   �� 5"       �@�Cursor$
 Hand��6/   5#      5&      �� 5'   
   " ��6!   .�5(      ��  � ��$ 20(�6)   �� 5)       � ��$ 200px��6&   �� 5*       � ��$
 50px��6'   �� 5+       � ��$ Center=�69   �� 5,       � ��$ LeftToRight=�6.   �� 5-       � �� �	#FF0606066,   5.      �� 5/   
   .��50      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $ PulseBox��6�   .\�51        $ 0:0:0.25��6'   $	 0.9Q�6:     52      $ 0:0:0.35��6'   $ 1Q�6:   53      U� 54      $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6,   $ PulseBox��6�   .\�55        $ 0:0:0.25��6'   $	 0.9Q�6:     56      $ 0:0:0.35��6'   $ 1Q�6:   57      58      59      .��5:      � 
������� � RowDefinitions 5;   
   �� 5<      $��* �6   �� 5=      $��2* �6   .+�5?   
   � $��0��6   $��	0,55,0,55q�6   .+�5@      �� -   5         ��Name$ PulseBox��5@      $��../../Images/tick.png��6(   z�5A      V� 5B      .~�5C      �� �� 5D      �� 5E      T� 5F      5G      5I      5J      � 5K   
   $��1��6   .+�5L      �� $	��top=�6   .+�5N      �� $��RightToLeft=�6   $��Center=�68   $��0,10,0,0q�6U   MKکد اهراز هویت به حساب تلگرام شما ارسال شد.6�   �� 5O      -   5         ��Name$ inp_code��5O      #��[  6,   $��Center=�6N   $��0,40,0,0q�6i   6�   �� 5P      -   5         ��Name$ txt_countdown��5P      $��Bottom=�63   $��Center=�6N   $��0,5,0,0q�6k   ���	#FF0A82DE�� 6�   -   5        $ 
txt_second��5P   �   $��14(�6�   01:596�    ثانیه6�   �� 5Q      -   5        $ txt_send_code_again��5Q      $��Center=�6:   ���	#FF0A82DE � Cursor$
 Hand��6n   $y�	Collapsed=�6�    �� Padding$ 0,5,0,0q�6�   $��14(�6�   ارسال دوباره کد6  �� 5S      -   5         ��Name$ btn_confirm_code��5S      $��ثبت کد��63   $��0,20,0,0q�6D   6w   �� 5T      -   5        $ btn_edit_number��5T      $��ویرایش شماره��62   $��0,20,0,0q�6I   $y�	Collapsed=�6y   6�   5X      5Y      5[       � Triggers 5\      :� 5]   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5^      �� #��[ 6   6E   5_      5a      