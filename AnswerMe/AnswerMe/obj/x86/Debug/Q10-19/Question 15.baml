   M S B A M L   `   `   `  ����F  BAnswerMe, Version=1.0.1.1376, Culture=neutral, PublicKeyToken=null#clr-namespace:AnswerMeAnswerMe  5          AnswerMe.Question_15   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      %myclr-namespace:AnswerMe     5      @d2http://schemas.microsoft.com/expression/blend/2008     60   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6m   $	��600��5      $	��600��6     � 	Resources  5         OnMouseEnterBlue �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OnMouseLeaveBlue  OnMouseEnterGreen  OnMouseLeaveGreen  OnMouseEnterRed  OnMouseLeaveRed��%�  &	        &	 �     &	      &	 �    &	 B    &	 �    �� 5      .��5      U� $ (UIElement.Opacity)�6#   $ 	textBlock��6S   .\�5	        $ 0��6   $ 1Q�6'   5
      5      �� 5      .��5      U� $ (UIElement.Opacity)�6#   $ 	textBlock��6S   .\�5        $ 0��6   $ 0Q�6'   5      5      �� 5      .��5      U� $ (UIElement.Opacity)�6#   $ 
textBlock1��6S   .\�5        $ 0��6   $ 1Q�6'   5      5      �� 5      .��5      U� $ (UIElement.Opacity)�6#   $ 
textBlock1��6S   .\�5        $ 0��6   $ 0Q�6'   5      5      �� 5      .��5      U� $ (UIElement.Opacity)�6#   $ 
textBlock2��6S   .\�5        $ 0��6   $ 1Q�6'   5      5      �� 5       .��5!      U� $ (UIElement.Opacity)�6#   $ 
textBlock2��6S   .\�5"        $ 0��6   $ 0Q�6'   5#      5$      5%       � Triggers 5&      :� 5'       :� RoutedEvent$ Mouse.MouseEnter��6    :� 
SourceName$ button��60   .[�5(      �� -   5         ��Name$&  OnMouseEnterBlue_BeginStoryboard��5(      #��[  6?   5)      :� 5*      $ Mouse.MouseLeave��6   $ button��60   .[�5+      �� -   5        $&  OnMouseLeaveBlue_BeginStoryboard��5+      #��[ 6?   5,      :� 5-      $ Mouse.MouseEnter��6   $ button1��60   .[�5.      �� -   5        $' !OnMouseEnterGreen_BeginStoryboard��5.      #��[ 6@   5/      :� 50      $ Mouse.MouseLeave��6   $ button1��60   .[�51      �� -   5        $' !OnMouseLeaveGreen_BeginStoryboard��51      #��[ 6@   52      :� 53      $ Mouse.MouseEnter��6   $ button2��60   .[�54      �� -   5        $% OnMouseEnterRed_BeginStoryboard��54      #��[ 6>   55      :� 56      $ Mouse.MouseLeave��6   $ button2��60   .[�57      �� -   5        $% OnMouseLeaveRed_BeginStoryboard��57      #��[ 6>   58      .��5:      � .+�5;   
      AnswerMe.QuestionNumber  	   QuestionNumber$	 15��6   $��12,12,488,488q�60      AnswerMe.OptionsLeft  5<   
   -   5        
  Name$

 btn1��5<   .   $��
Click Here��6   $��-6,488,306,12q�6<      AnswerMe.OptionsRight  5=   
   -   5          Name$
 btn2��5=   /   $��
Click Here��6   $��300,488,0,12q�6=   �� 5>   
   -	   5         ��Name$ button2��5>      $�� ��6"   $
��Left=�6-   $��53��6H   $��209,0,0,147q�6T   $��Bottom=�6i   $��53��6�   
���  ��6�   �� 5?   
   -
   5        $ button1��5?      $�� ��6"   $��53��6-   $��266,0,281,147q�69   $��Bottom=�6P   ���	#FF08FF006k   �� 5@   
   -   5        $ button��5@      $�� ��6!   $��Right=�6,   $��53��6H   $��0,0,224,147q�6T   $��Bottom=�6i   $��53��6�   ���	#FF1300FF6�   �� 5A   
   -   5         ��Name$ 
textBlock2��5A      $��96��6(   $��71,172,71,0q�64   $
��Wrap=�6I   $	��Top=�6]   $<��6/AnswerMe;component/Fonts/#Yoshi's Story game text BRK)�6u   $��48(�6�   
���  �� J� Opacity$ 0Q�6�   �� 6�   $�   ck          t ��6�   �� 6  �� 6  $� an        bu��6  6,  �� 5B   
   -   5        $ 
textBlock1��5B      $��96��6(   $��71,172,71,0q�64   $
��Wrap=�6I   $	��Top=�6]   $<��6/AnswerMe;component/Fonts/#Yoshi's Story game text BRK)�6u   $��48(�6�   ���	#FF00FF1B$ 0Q�6�   �� 6�   $�          ri��6�   �� 6  �� 6  $�    d    e    tt��6  60  �� 5C   
   -   5        $ 	textBlock��5C      $��96��6'   $��71,172,71,0q�63   $
��Wrap=�6H   $	��Top=�6\   $<��6/AnswerMe;component/Fonts/#Yoshi's Story game text BRK)�6t   $��48(�6�   ���	#FF001BFF$ 0Q�6�   �� 6�   $�Cli   the   gh��6�   �� 6  �� 6  $�h     sid       on��6  63  5D      5E      