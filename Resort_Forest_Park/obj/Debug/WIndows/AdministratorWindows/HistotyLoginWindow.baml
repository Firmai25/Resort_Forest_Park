   M S B A M L   `   `   `  ????M  IResort_Forest_Park, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Resort_Forest_Park.WIndows.AdministratorWindows/Resort_Forest_Park.WIndows.AdministratorWindows  5   	   H    BResort_Forest_Park.WIndows.AdministratorWindows.HistotyLoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Olocal=clr-namespace:Resort_Forest_Park.WIndows.AdministratorWindows     5   	     ? Title$  HistotyLoginWindow??5   	   $	??450??5	   	   $	??800??5
   	    ? WindowStartupLocation$ CenterScreen=?5   	   .??5      ? ???	#FF76E383 ? RowDefinitions 5   
   ?? 5      $??60 ?6   ?? 5      .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? -   5         ??Name$ CmLogin??5      $
??Left=?5      $	??200??5      $??40??5       ?? DisplayMemberPath$ Login??5      $??20,0,0,0q?5      $??Comic Sans MS)?5      ?? 5      -   5        $??Сбросить??5      $??10,0,0,0q?5      $??40??5      $??Comic Sans MS)?5      5      ?? 5    
   -   5        $??Right=?5       $??Вернуться ??5!      $??40??5"      $??0,0,10,0q?5#      $??Comic Sans MS)?5%      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ 	DgHistory??5'      $??1??5&         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5)      $??Comic Sans MS)?5*      	   Columns	 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Фамилия??6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ?? *Worker.Surname+  5-      $
 Имя??6%    62   ?? *Worker.Name+  5.      $
 Отчество??6%    67   ?? *Worker.Patronymic+  5/      $
 
Время??6%    64   ?? *
Time_Login+  50      $
 Действие??6%    67   ?? *
Type_Login+52      53      54      