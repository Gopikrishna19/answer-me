   M S B A M L   `   `   `  ����F  BAnswerMe, Version=1.0.1.1376, Culture=neutral, PublicKeyToken=null#clr-namespace:AnswerMeAnswerMe  5          AnswerMe.Question_14   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      %myclr-namespace:AnswerMe     5      @d2http://schemas.microsoft.com/expression/blend/2008     60   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6m   $	��600��5      $	��600��6     � 	Resources  5         	OnLoaded1 g� RepeatBehavior �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime  System.Windows.Visibility   Hidden R� Value	   Visible��%�  &	        �� 5      $ 3��6!   .��5      U� $ (UIElement.Opacity)�6#   $
 grid��6S   .\�5	        $ 0:0:4��6   $ 0Q�6+     5
      $ 	0:0:4.050��6   $ 1Q�6/     5      $ 0:0:4.2��6   $ 0Q�6-   5      T� 5      $ (UIElement.Visibility)�6#   $
 grid��6V   ..�5      i� $ 0:0:4��6   # Z 6-   i� 5      $ 0:0:4.05��6   # Z	 60   i� 5      $ 0:0:4.1��6   # Z 6/   5      5      5      
 � Triggers
 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      � .+�5   
      AnswerMe.QuestionNumber  -   5          Name$ QuestionNumber1��5   J   $
��Left=�6   $��	12,12,0,0q�67   $	��Top=�6c   $	��200��6{   $	��200��6�      QuestionNumber$ 14��6�      AnswerMe.OptionsRight  5   
   -   5          Name$ OptionsRight1��5   X   $	��180��6   $
��Left=�6(   $��300,382,0,0q�6C   $	��Top=�6o   $	��402��6�   $�� ��6�     5   
   -   5        $ OptionsRight2��5   W   $��23��6   $
��Left=�6'   $��300,488,0,0q�6B   $	��Top=�6n   $��75��6�   $�� ��6�      AnswerMe.OptionsLeft  5   
   -   5          Name$ OptionsLeft1��5   U   $��23��6   $
��Left=�6&   $��
-8,382,0,0q�6A   $	��Top=�6k   $��75��6�   $�� ��6�     5   
   -   5        $ OptionsLeft2��5   U   $��23��6   $
��Left=�6&   $��
-8,488,0,0q�6A   $	��Top=�6k   $��75��6�   $�� ��6�      AnswerMe.QuestionBox  5   
   -   5          Name$ QuestionBox1��5   I   $
��Left=�6   $��100,143,0,0q�64   $	��Top=�6_   $	��149��6w   $	��472��6�      QuestionContent$ Watch Carefully!��6�   � 5    
   -   5         �Name$
 grid��5       $	��234��6   $��12,0,8,8q�6*   $��Bottom=�6<    J� Opacity$ 0Q�6W   .+�5!      �� ���	#FFD85910$
��Left=�6&   $��46��6A   $��	30,50,0,0q�6M   
���   �$	��Top=�6o   $	��209��6�   �� 5"      ���	#FF1BCC36$��Right=�6&   $��46��6B   $��	0,50,40,0q�6N   
���   �$	��Top=�6p   $	��215��6�   �� 5#      ���	#FFD85910$��Right=�6&   $��41��6B   $��	0,0,40,27q�6N   
���   �$��Bottom=�6p   $	��215��6�   �� 5$      ���	#FFD85910$
��Left=�6&   $��41��6A   $��	30,0,0,27q�6M   
���   �$��Bottom=�6o   $	��209��6�   5%      5&      5'      