   M S B A M L   `   `   `  ����C  ?Employee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:EmployeeEmployee  5   	       Employee.EditEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Employee     5   	     � Title$  EditEmployee��5   	   $	��400��6   $
��1100��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeeGrid��5
      $
��Left=�6)   $��	47,26,0,0q�6D   $	��Top=�6W   $	��303��6o   $	��720��6|      AutoGenerateColumns .  ��6�   ��  �� Path$ EmployeeList� �� SelectedItem 6�   �� $ SelectedEmployee�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� $ 
EmployeeID�6^     5      $ 
First Name��6%   $ 80 6]    6:   �� $ 	FirstName�6]     5      $ Middle Name��6%   $	 100 6^    6:   �� $ 
MiddleName�6^     5      $ 	Last Name��6%   $	 100 6Z    68   �� $ LastName�6Z     5      $ Email��6%   $	 120 6S    64   �� $ Email�6S     5      $ Address��6%   $	 180 6Z    66   �� $ 
Emp_Adress�6Z     5      $ Status��6%   $	 100 6U    65   �� $ Status�6U   5      �� 5   
   -   5        	 ��Name$
	 Edit��5      $��	Edit Info��6   $
��Left=�63   $��
848,69,0,0q�6N   $	��Top=�6b   $	��163��6z   $��42��6�   ��6�   �� *UpdateEmployeeBtn+�� 5   
   -   5        $	 Delete��5      $��Delete��6!   $
��Left=�62   $��848,130,0,0q�6M   $	��Top=�6b   $	��163��6z   $��37��6�   ��6�   �� *DeleteEmployeeBtn+�� 5   
   -   5        $	 Cancel��5      $��Cancel��6!   $
��Left=�62   $��848,194,0,0q�6M   $	��Top=�6b   $	��163��6z   $��39��6�   6�   5      5      