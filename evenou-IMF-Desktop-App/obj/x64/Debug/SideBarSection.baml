   M S B A M L   `   `   `  ����Q  Mevenou-IMF-Desktop-App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:evenou_IMF_Desktop_Appevenou_IMF_Desktop_App  5      +    %evenou_IMF_Desktop_App.SideBarSection   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:evenou_IMF_Desktop_App     5        � DataContext  5   7   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+ � 	Resources 5	       �� 
TargetType   CustomButtonStyle �� Property �� Value �� 
TargetType ��Name	 �� Triggers
 ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value �� 
StartPoint �� EndPoint � Color � Offset��%�  &	        �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 0,0,0,1q�60   �� 5       � �� �#d2d5d66,   �� 5       � ��$ 5q�6(   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   #��z��61   #��z��5   !   #��z��6M   ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      ]� 5      
 5   "   �� 5   &    �@J�IsMouseOver . 6G   �� 5   &    �@�Tag$ False��6?   �� 5   &    � �� .  6E   ./�5   "   �� $ border��6)    � ��
 ��  �6S   �� 5   "    � ��
 �����6?   5       P� 5!       � �� . . �5"   "   ��  � ��
 ��  �6?   �� 5#   "    � ��
 �����6?   5$      P� 5%       �@�Tag$
 True��65   . �5&   "   �� $ border��6)    � ��$ 3,1,0,1q�6X   �� 5'   "   $ border��6)    � �� 5(   &   �� 5)   *   $	 0,0&�6>   $	 1,0&�6O   .��5*   .   � $
 Blue��6;   $ 0Q�6H   � 5+   .   $ Transparent��6;   $	 0.5Q�6O   5,   +   5.   #   �� 5/   "   $ border��6)    � �� �	#FFF2F6FC6S   50      52      54      55      56      .��58      � .+�59   
   �� -   5        $��SectionButton��59      #��[  6&   $��45��5;      $��13(�6   ��5:      �� *	Content+ �� *FindAncestor+ �� AncestorType+   %evenou_IMF_Desktop_App.SideBarSection"  5=      5>      5?      