   M S B A M L   `   `   `  ����M  IWpfControlLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfControlLibrary1WpfControlLibrary1  5      7 clr-namespace:WpfControlLibrary1WpfControlLibrary1  5      (    "WpfControlLibrary1.UserControlView   5   
   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      0local clr-namespace:WpfControlLibrary1    5      .cmd clr-namespace:WpfControlLibrary1    5        � 	Resources  5      5   /WpfControlLibrary1.BooleanToVisibilityConverter !  booleanToVisiabilityConverter��%   &	          5   
   6-   5	      ��5
      �� 5   
   .R�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� ��6   ��  �� Path$ DataContext.FileName� �� RelativeSource ��  �� AncestorType" ���� 5      $��*��6   y�6%   �� $ DataContext.IsTextChanged� �� 	Converter# [   �� " ��5      5       � ContextMenu 5      �� 5   
    �� 	StaysOpen . .@�5      m� $��Close��6    m� Command 6&   �� *CloseCommand+5      .��5      � .+�5   
   �� ��6   �� $ FileText�	 �� Mode$	 TwoWay=�$   WpfControlLibrary1.TextChanged
   Command
 5      �� *TextChangedCommand+5      5      