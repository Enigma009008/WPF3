   M S B A M L   `   `   `  ����?  ;WPF3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF3.Views.PagesWPF3.Views.Pages  5          WPF3.Views.Pages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WPF3.Views.Pages     5      -   5          N� 
Background
  ����� N� Title$ Главное окно��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   � .+�5      �� $��0��6   $��Center=�6&   $��Center=�6A    �� Orientation$ 
Horizontal=�6^   .+�5      �� $��Поиск:��6   $��70��6+   $��20��66   $��15(�6B   �� 5      -   5         ��Name$ 	TxbSearch��5      $	��250��6-   $��30��69   $��10q�6E   �� 5      -   5         ��Name$ ButtonSearch��5      $��
Поиск��6/   $��30��6?   $	��150��6K   
��� ���6r   5      5      � 5   
   $��1��6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��
DataSource��5         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+  5!      $
 
Автор��6)    68   �� *Author.GetFullName+  5"      $!
 Название книги��6)    6A   �� *Title+  5#      $
 Жанр��6)    67   �� *Genre.Title+  5$      $
 Издатель��6)    6;   �� *Publisher.Title+5&      5'      � 5)   
   $��2��6   .+�5*      �� $��Center=�6   $��Center=�66   $ 
Horizontal=�6Q   .+�5+      �� -   5        $��BtnAdd��5.      $��Создать��5+      $��133.33��5,      $��30��5-      5/      �� 51      -   5        $��BtnEdit��55      $ ��Редактировать��51      $��133.33��52      $��30��53      $
��10,0q�54      56      �� 58      -   5        $��	BtnDelete��5;      $��Удалить��58      $��133.33��59      $��30��5:      5<      5>      5?      5B      5C      