   M S B A M L   `   `   `  ����Q  Mevenou-IMF-Desktop-App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:evenou_IMF_Desktop_Appevenou_IMF_Desktop_App  5      2    ,evenou_IMF_Desktop_App.VerticalNavigationBar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:evenou_IMF_Desktop_App     5        � DataContext  5      ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+ � 	Resources 5
         SelectedButtonStyle �� 
TargetType �� Property �� Value��%z   &	        �� 5   
   " ��6,   .�5      ��  � ��
 ��ح�6+   �� 5       � ��
 �����6+   5      5      .��5      � 
�������$��200px��6   $
��Left=�6,    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6   	   Opacity$		 0.2Q�6-   
   
BlurRadius$
 30Q�6;      	Direction$ 0Q�6K      ShadowDepth$ 1Q�6Y   .+�5   
   �� .+�5      �� $��45��6   $��0,0,0,1q�6"   ���#bbbbbb$��5,0,5,0q�6R   ._�5      � $��Center=�6   $��Center=�64   $��0,0,0,-2q�6O    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $
��Auto �6+   .+�5      �� -   5        $	��img��5      $��27��5      ��5      �� *Logo+ �� *FindAncestor+ �� AncestorType2   ,evenou_IMF_Desktop_App.VerticalNavigationBar"    5   #   �� $ OneWay=� �� *Self+�� 5      $��1��6    $��Gestionnaire Microfinance��60   $��13(�6Q   $��Center=�6_   $��Center=�6z   $
��Bold"�6�   5!      5"      +   %evenou_IMF_Desktop_App.SideBarSection  5#         Content$ Credit��6#     5$      $ Epargne��6#     5%      $ Tontines��6#     5&      $ Gestionnaires��6#     5'      $ Clients��6#   5?      5@      5B      