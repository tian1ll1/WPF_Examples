   M S B A M L   `   `   `  ����  ModularityWithMef.Desktop-    'ModularityWithMef.Desktop.ModuleControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          � UseLayoutRounding  . .��5      � -   5         �Name$ 
LayoutRoot��5      $��Stretch=�6   $��Stretch=�6=   .+�5   
   �� $��Center=�6   $��Center=�6.   ._�5      � $��Center=�6   $��Center=�60    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $
��Wrap=�6    �� TextAlignment$ Center=�5      $��Center=�5      $��Center=�69   ��5      �� *
ModuleName+ �� FallbackValue$ Unknown��5   9   �� 5      -   5         ��Name$ ClickToLoadTextBlock��5      $
��Wrap=�5      $ Center=�60   $��Center=�5      $��Center=�69   $��(Click to load)��5      $��1��63   ���	#FFDE8310$y�	Collapsed=�6W   $��9.667(�6n   � 5      -   5        $ LoadProgressPanel��5   $   $��2��6    5      �� 5      $
��Auto �6(   �� 5       $
��Auto �6(   .+�5"      �  � Maximum$	 100Q�6\   $��2q�6j   $��10��6u    � Value 6"   �� *DownloadProgressPercentage+ �� Mode$ OneWay=�6u   �� 5#      $��1��6!   	 �� Orientation$	 
Horizontal=�6.   $��Center=�6G   $��Center=�6d   .+�5$      �� $
��Wrap=�6$   $��9.667(�5&      ��5%      �� *DownloadProgressPercentage+$ OneWay=�5&      �� 5'      $��%��6$   $��9.667(�6-   5(      5)      5*      5+      5,      
 ^� ToolTip
 5.      � 5/   
    50      �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    �� 54      $
��Auto �6    �� 55      $
��Auto �6     � ColumnDefinitions 57      �� 58      $	��100 �6#   61   �� 59      $	��200 �6#   61   .+�5;      �� $��0��6   $��0��6(   $��Status: ��65   �� 5<      $��1��6   $��0��6(   $
��Wrap=�65   ��6I   �� *ModuleInitializationStatus+$ Unknown���� 5>      $��0��6   $��1��6(   $��Discovery: ��65   �� 5?      $��1��6   $��1��6(   $
��Wrap=�65   ��6I   �� *ExpectedDiscoveryMethod+$ Unknown���� 5A      $��0��6   $��2��6(   $��Initialized: ��65   �� 5B      $��1��6   $��2��6(   $
��Wrap=�65   ��6I   �� *ExpectedInitializationMode+$ Unknown���� 5D      $��0��6   $��3��6(   $��Downloaded: ��65   �� 5E      $��1��6   $��3��6(   $
��Wrap=�65   ��6I   �� *ExpectedDownloadTiming+$ Unknown���� 5G      $��0��6   $��4��6(   $��Depends On: ��65   �� 5H      $��1��6   $��4��6(   $
��Wrap=�65   ��6I   �� *ConfiguredDependencies+$ Unknown��5I      5K      