   M S B A M L   `   `   `  ����G  CProgramPraca, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ProgramPraca.PodOknaMainProgramPraca.PodOknaMain  5   	   (    "ProgramPraca.PodOknaMain.AddColumn   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ProgramPraca.PodOknaMain     5   	   _ [Syncfusion.Edit.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Gantt.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89_	 [Syncfusion.Grid.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89e
 aSyncfusion.GridCommon.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Linq.Base, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h dSyncfusion.PivotAnalysis.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89g cSyncfusion.PropertyGrid.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f bSyncfusion.SfAccordion.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h dSyncfusion.SfBulletGraph.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89j fSyncfusion.SfBusyIndicator.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89e aSyncfusion.SfCellGrid.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfChart.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89d `Syncfusion.SfDiagram.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89j fSyncfusion.SfDiagramRibbon.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfGauge.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfGrid.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89d `Syncfusion.SfHeatMap.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89d `Syncfusion.SfHubTile.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h dSyncfusion.SfImageEditor.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfInput.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a ]Syncfusion.SfMaps.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89m iSyncfusion.SfNavigationDrawer.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h dSyncfusion.SfProgressBar.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89g cSyncfusion.SfRadialMenu.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89k gSyncfusion.SfRichTextBoxAdv.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89k  gSyncfusion.SfRichTextRibbon.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89e! aSyncfusion.SfSchedule.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f" bSyncfusion.SfScheduler.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h# dSyncfusion.SfSkinManager.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89i$ eSyncfusion.SfSpellChecker.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h% dSyncfusion.SfSpreadsheet.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89l& hSyncfusion.SfTextInputLayout.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89d' `Syncfusion.SfTreeMap.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89j( fSyncfusion.SfTreeNavigator.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89e) aSyncfusion.SfTreeView.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a* ]Syncfusion.Shared.WPF, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89i+ eSyncfusion.Shared.WPF.Classic, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89`, \Syncfusion.Tools.Wpf, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89h- dSyncfusion.Tools.Wpf.Classic, Version=19.4500.0.38, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89~
Syncfusion!http://schemas.syncfusion.com/wpf'   	 
                        ! " # $ % & ' ( ) * + , - 5   	     � Title$  	AddColumn��5
   	   $	��400��6   $	��550��6(    � 
ResizeMode$ NoResize=�64    � WindowStartupLocation$ CenterOwner=�6J   .��5      � .+�5   
   �� $
��Left=�6   $��	23,10,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $��Roboto Medium)�6n   $��48(�6�    J� RenderTransformOrigin$ 0.546,0.612&�6�   $��60��6�   
�������$��Dodaj Kolumnę
��6�   ${�False��6�   ���	#FF87BC5E$	��504��6  $��Normal&�6)  $��LeftToRight=�6>   �� Padding$ 0,0,0,0q�6Z   � UseLayoutRounding$
 True��6l   �� TextAlignment$ Center=�6�  �� 5   
   -   5         ��Name$ Button1��5      $��Dodaj kolumnę��6"   $��Center=�6:   $��	0,322,0,0q�6W   $	��Top=�6j    K� ZIndex$ 6��6�   
����������	#FFAEAEAE$	��250��6�   $��30��6�   $
 True��6�   ���	#FF87BC5E	 �� 	ClickMode$	 Release=�6  $��16(�6  6(  �� 5   
   -   5        
 ��Name$
 TextBlockColumnName��5      $
��Left=�61   $��
104,82,0,0q�6L   $��Nazwa: ��6`   $
��Wrap=�6o   $	��Top=�6�   $��26��6�   $��66��6�   $��16(�6�   $ 0.561,0.691&�6�   �� 5   
   -   5         ��Name$ TextBoxColumnName��5      $��Center=�6-   $��0,84,0,0q�6J    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��200��6�   $��22��6�   �� 5   
   $
��Left=�6   $��
23,115,0,0q�6/   $��Wybierz przynależność:��6C   $
��Wrap=�6a   $	��Top=�6u   $��13(�6�   �� 5   
   -   5         ��Name$ ComboBoxOwnerType��5      $��Center=�6.   $��	0,112,0,0q�6K   $	��Top=�6^   $	��200��6v   
�������
�������6�   �� 5   
   -   5         ��Name$ CheckBoxIsEnum��5      $��Typ wyliczeniowy��6+   $
��Left=�6F   $��175,139,0,0q�6a   $	��Top=�6v   6�   �� 5   
   -   5         ��Name$ ListBoxEnumValues��5      $��118,159,232,95q�6-   $	��130��6�   $	��200��6�   �� 5   
   -   5        $ TextBoxNewEnumValue��5      $
��Left=�6/   $��175,294,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��130��6�   $��20��6�   �� 5   
   -   5        $
 plus��5      $��+��6   $
��Left=�6+   $��315,289,0,0q�6F   $	��Top=�6[   $��20��6s   $��25��6~   
����������	#FF87BC5E$��0,0,0,0q�6�   $��Center=�6�   $��Center=�6  $��0,0,0,0q�6)  $��LeftToRight=�6;  $��Normal$�6W  $��Normal&�6j  $��Black"�6  $��20(�6�  
�������6�  �� 5   
   -	   5        $ minus��5      $��-��6    $
��Left=�6,   $��348,289,0,0q�6G   $	��Top=�6\   $��20��6t   $��25��6   
����������	#FF87BC5E$��20(�6�   $��0,0,0,0q�6�   
�������$��Black"�6  �� 5   
   -
   5        $ ListBoxColors��5      $��325,159,100,95q�6T   �� 5   
   -   5        $ CheckBoxIsChecked��5      $��Pole Prawda/Fałsz��6.   $
��Left=�6J   $��303,139,0,0q�6e   $	��Top=�6z   6�   5      5      