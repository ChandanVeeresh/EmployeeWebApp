   M S B A M L   `   `   `  ����C  ?Employee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:EmployeeEmployee  5   	       Employee.AddEmployee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Employee     5   	     � Title$  AddEmployee��5   	   $	��450��6   $	��600��6*   .��5	      � .+�5
   
   �� -   5         ��Name$ 	FirstName��5
      $��
First Name��6#   $
��Left=�68   $��	37,40,0,0q�6S   $	��Top=�6f   $	��158��6~   �� 5   
   -   5        $ 
MiddleName��5      $��Middle Name��6$   $
��Left=�6:   $��	37,70,0,0q�6U   $	��Top=�6h   $	��158��6�   �� 5   
   -   5        $ LastName��5      $��	Last Name��6"   $
��Left=�66   $��
37,100,0,0q�6Q   $	��Top=�6e   $	��158��6}   �� 5   
   -   5        $ emailId��5      $��Email Id��6!   $
��Left=�64   $��
37,130,0,0q�6O   $	��Top=�6c   $	��158��6{   �� 5   
   -   5        $ Status��5      $��Status��6    $
��Left=�61   $��
37,160,0,0q�6L   $	��Top=�6`   $	��158��6x   �� 5   
   -   5        $ 
empAddress��5      $��Address��6$   $
��Left=�66   $��
37,200,0,0q�6Q   $	��Top=�6e   $	��158��6}   �� 5   
   -   5         ��Name$ 	firstName��5      $
��Left=�6%   $��23��6@   $��
309,40,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6�   $	��200��6�   ��6t   �� *	FirstName+6�   �� 5   
   -   5        $ 
middleName��5      $
��Left=�6&   $��23��6A   $��
309,70,0,0q�6M   $
 Wrap=�6a   $	��Top=�6�   $	��200��6�   ��6u   �� *
MiddleName+6�   �� 5   
   -	   5        $ lastName��5      $
��Left=�6$   $��23��6?   $��309,100,0,0q�6K   $
 Wrap=�6`   $	��Top=�6�   $	��200��6�   ��6t   �� *
LastName+6�   �� 5   
   -
   5        $ email��5      $
��Left=�6!   $��23��6<   $��309,133,0,0q�6H   $
 Wrap=�6]   $	��Top=�6�   $	��200��6�   ��6q   �� *Email+6�   �� 5   
   -   5        $ Address��5      $
��Left=�6#   $��85��6>   $��309,200,0,0q�6J   $
 Wrap=�6_   $	��Top=�6�   $	��200��6�   ��6s   �� *	Address+6�   �� 5   
   -   5         ��Name$ Add_Employee��5      $	��Add��6'   $
��Left=�65   $��
88,328,0,0q�6u   $	��Top=�6�   $	��169��6�   $��47��6�   ��6P   ��  �� Path$ addEmployee�6�   �� 5   
   -   5        $ Cancel��5      $��Cancel��6!   $
��Left=�62   $��309,328,0,0q�6N   $	��Top=�6c   $	��200��6{   $��47��6�   6�   	� 5   
   -   5         	�Name$ Activate��5      $��Activate��6(   $
��Left=�6<   $��309,173,0,0q�6W   $	��Top=�6l    d� 	IsChecked 6�   �� *
IsActivate+	� 5   
   -   5        $ 
Deactivate��5      $��
Deactivate��6*   $
��Left=�6?   $��412,173,0,0q�6Z   $	��Top=�6o    6�   �� *IsDeactivate+5      5      