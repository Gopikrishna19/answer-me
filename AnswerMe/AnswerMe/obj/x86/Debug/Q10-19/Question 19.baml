   M S B A M L   `   `   `  ����F  BAnswerMe, Version=1.0.1.1376, Culture=neutral, PublicKeyToken=null#clr-namespace:AnswerMeAnswerMe  5          AnswerMe.Question_19   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      %myclr-namespace:AnswerMe     5      $	��600��60   $	��600��6=     � 	Resources  5         	OnLoaded1 �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction/  )System.Windows.Media.Animation.BounceEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   Bounces   
Bounciness	 R� KeyTime  System.Windows.Visibility
   Visible R� Value   Hidden��%P  &	        �� 5      .��5      U� $ (UIElement.Opacity)�6#   $
 grid��6S   .\�5        $ 0:0:3��6   $ 0Q�6+    5	        5
      $ EaseIn=�6   $ 10��6'   $ 1Q�64   5        5      $ 0:0:4��6   $ 1Q�6+    5        5      $ EaseIn=�6   $ 10��6'   $ 1Q�64   5      5      U� 5      $ (UIElement.Opacity)�6#   $ grid1��6S   .\�5        $ 0:0:3��6   $ 1Q�6+    5        5      $ EaseOut=�6   $ 10��6(   $ 1Q�65   5        5      $ 0:0:4��6   $ 0Q�6+    5        5      $ EaseOut=�6   $ 10��6(   $ 1Q�65   5      5      T� 5      $ (UIElement.Visibility)�6#   $ grid1��6V   ..�5       i� $	 0:0:3��6   # Z
 6-   i� 5!      $	 0:0:4��6   # Z 6-   5"      5#      5$       � Triggers 5%      :� 5&       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5'      �� #��[  6   5(      .��5*      � .+�5+   
      AnswerMe.QuestionNumber  -   5          Name$ QuestionNumber1��5+   J   $
��Left=�6   $��	12,12,0,0q�67   $	��Top=�6c      QuestionNumber$ 19��6{   � 5,   
   -   5         �Name$
 grid��5,      $��
85,130,8,8q�6    J� Opacity$ 0Q�61   .+�5-      F� -   5         F�Name$ path2��5-      +���� �2��/�`� 7YѠ�����Ѡ�F�87	���	#FF67E555$��171.5��6g   $��101.5,0,103.5,52.5q�6v    �� Stretch$
 Fill=�6�   
���   �$��Bottom=�6�   $��10��6�   �� 5.      $
��Left=�6   $��	53,39,0,0q�60   $
��Wrap=�6C   $.��(Instead Press this button to  proceed :)��6W   $	��Top=�6�   ���	#FF58D66B$<��6/AnswerMe;component/Fonts/#Yoshi's Story game text BRK)�6�   $��48(�6�   5/      � 50   
   -   5        $ grid1��50      $��
85,130,8,8q�6   .+�51      F� -   5        $ path1��51      +���� �2��/�`� 7YѠ�����Ѡ�F�87	���	#FFE55555$��171.5��6g   $��101.5,0,103.5,52.5q�6v   $
 Fill=�6�   
���   �$��Bottom=�6�   $��10��6�   �� 52      $
��Left=�6   $��	53,39,0,0q�60   $
��Wrap=�6C   $1��+If you touch this button the game is over !��6W   $	��Top=�6�   ���	#FFD65858$<��6/AnswerMe;component/Fonts/#Yoshi's Story game text BRK)�6�   $��48(�6�   53      54      55      