   M S B A M L   `   `   `  ����  PrismDemo.Mvvm,    &PrismDemo.Mvvm.Views.QuestionnaireView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ ../Theme/Theme.xaml?�6%   %    5      .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��3��5      $��Stretch=�5      .��5      �  5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5       $
��Auto �6$   �� 5!      $
��Auto �6$   .+�5#      �� $��0��6      HeaderedBorderStyle#��[  5$      ._�5%      �  5&      �� 5'      $
��Auto �6,   �� 5(      $
��Auto �6,    5*      �� 5+      $
��Auto �6/   �� 5,      $
��Auto �6/   .+�5.      �� $��0��6$   $��0��5/   $   $��Bottom=�50   $   �� 6@   $
�Name��6D   6T   �� 51      -   5         ��Name$ NameTextBox��51   "   $��1��52   "   $��0��53   "   $	��150��55   "   $��2q�56   "   4  .System.Windows.Automation.AutomationProperties   AutomationId$ NameText��6-   ��54   "   �� *Questionnaire.Name+ �� Mode$ TwoWay=�56   -   �� 57      $��0��6$   $��1��58   $   $��Bottom=�59   $   �� 6@   $	�Age��6D   6S   �� 5:      -   5        $ 
AgeTextBox��5:   "   $��1��5;   "   $��1��5<   "   $
��Left=�5=   "   	 �� 	MaxLength$	 3��5?   "   $��40��5@   "   $��2q�5A   "   $ AgeText��6-   ��5>   "   �� *Questionnaire.Age+$ TwoWay=�5A   -   5B      5C      � 5D      $��1��6   $��5q�5E       5F      �� 5G      $
��Auto �6(   �� 5H      $
��Auto �6(    5J      �� 5K      $��* �6+   .+�5M      �� $��0��6    $��What is your quest?��5N         QuestionLabelStyle#��[ 5O       �� 5P      -   5        $ Question1Response��5P      $��1��5Q      $ Question1Text��5S      ��5R      �� *Questionnaire.Quest+$ TwoWay=�5S      5T      � 5U      $��2��6   $��5q�5V       5W      �� 5X      $��* �6+    5Z      �� 5[      $
��Auto �6(   �� 5\      $
��Auto �6(   .+�5^      �� $��0��6    #��[ 5_       �� 5`      $�What is your favorite ��6   �� 6?   -   5        
 ��Name$
 ColorRun��5`   C   $�color��5a   C   ��5b   C   �� *Questionnaire.FavoriteColor+ �� TargetNullValue$ Black���� 6�   $�?��6�   5c      �� 5d      $��1��6     BorderBrush#��[ 5e      ._�5f      �� -   5         ��Name$ Colors��5f   "   ��.  $��5q�5i   "   ��5h   "   �� *	AllColors+ �� SelectedItem 5j   "   �� *Questionnaire.FavoriteColor+$ TwoWay=�5k      5l      5m      5n      5o      5p      5r      