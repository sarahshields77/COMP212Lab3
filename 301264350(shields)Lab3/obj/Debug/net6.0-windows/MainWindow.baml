   M S B A M L   `   `   `  ����Q  M301264350(shields)Lab3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:_301264350_shields_Lab3_301264350_shields_Lab3  5   	   (    "_301264350_shields_Lab3.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:_301264350_shields_Lab3     5   	     � Title$   Restaurant Bill Calculator��5   	   $	��450��6,   $	��800��69   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��0��6   $��	0,0,0,260q�6   $��2��6/    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��10,17,307,33q�6)   .+�5      �� $��Beverage��6   $��0,10,0,5q�6,   $
��Bold"�6>   �� 5      $��Main Course��6   $��0,10,0,5q�6/   $
��Bold"�6A   5      �� 5      $��1��6   $��8,17,280,33q�6)   .+�5      �� $��	Appetizer��6   $��0,10,0,5q�6-   $
��Bold"�6?   �� 5      $��Dessert��6   $��0,10,0,5q�6+   $
��Bold"�6=   5      �� 5      -   5         ��Name$ comboBoxBeverage��5      $��98,24,97,72q�61   6F   �� 5      -   5        $ comboBoxMainCourse��5      $��98,53,97,43q�63   6H   �� 5       -   5        $ comboBoxDessert��5       $��87,53,91,43q�60    J� RenderTransformOrigin$ 2.714,3.268&�6y   $��1��6�   �� 5!      -   5        $ comboBoxAppetizer��5!      $��87,24,91,72q�62   $ 3.559,2.332&�6}   $��1��6�   5"      �� 5%   
   $��0��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��10q�6K   &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ dataGridBill��5(      $��1��6)   $��10,73,144,10q�66      AutoGenerateColumns$ False��6w   ��6L   �� *SelectedBillItems+   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Item��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6L     5+      $	 Price��6%   $
 * 6_    64   �� *Price+ �� StringFormat$ C2��6_     5,      $	 Quantity��6%   $
 * 6T    67   �� *
Quantity+6T   5.      �� 51   
   $��1��6   $��683,123,10,0q�6"   $	��Top=�68   $	��131��6P   .+�52      �� $��0,0,0,10q�6   .+�53      �� $��
Subtotal: ��6   $
��Bold"�6.   �� 54      -   5         ��Name$ textBlockSubtotal��54      $��$0.00��67   55      �� 56      $��0,0,0,10q�6   .+�57      �� $��Tax: ��6   $��0,0,5,0q�6)   $
��Bold"�6:   �� 58      -   5        $ textBlockTax��58      $��$0.00��62   59      �� 5:      $��0,0,0,10q�6   .+�5;      �� $��Total: ��6   $��0,0,5,0q�6+   $
��Bold"�6<   �� 5<      -   5        $ textBlockTotal��5<      $��$0.00��64   5=      5>      �� 5A   
   -	   5        $��1��5A      $��
Clear Bill��6   $��0,304,10,10q�6K   $��Right=�6`   $	��107��6|   $
��Bold"�6�   �� 5D   
   $��2��6   .@�5E      �� .��5F      �� $ 
Horizontal=�6   5G      �� 5H      -
   5         ��Name$ companyLogo��5H      $ ��Images/centennial_logo.png��6)   $	��162��6M   $��29��6Y   $��Right=�6�   �� 5I      $(��"Sarah Shields | Centennial College��6   $��Center=�6B   $	��183��6]   $��Right=�6i   5J      5K      5L      