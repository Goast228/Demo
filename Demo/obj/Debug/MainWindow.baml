   M S B A M L   `   `   `  ����?  ;Demo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DemoDemo  5   	   J FEasyCaptcha.Wpf, Version=0.9.0.3, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:EasyCaptcha.Wpf;assembly=EasyCaptcha.WpfEasyCaptcha.Wpf 5   	       Demo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Demo     5   	   Fwpf6clr-namespace:EasyCaptcha.Wpf;assembly=EasyCaptcha.Wpf     5   	     � Title$  Авторизация��5	      $	��350��6   $	��400��6)   $��Comic Sans MS)�65   .��5
      � ���#FFFFFF � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��30 �6   �� 5      -   5         ��Name$ UserNameForm��5      $��50 �62   �� 5      -   5        $ UserPasswordForm��5      $��50 �66   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   .+�5   
   �� $��0��6   $��Авторизация��6   $��30(�63   $
��Bold"�6A   $��Center=�6S   $��Center=�6w   �� 5   
   -   5         ��Name$ NavigateText��5      $��1��6   $����Пожалуйста, введите свои данные для входа или продолжайте в качестве гостя��63   $��10(�6�   $��Center=�6�   $��Center=�6�   �� 5   
   $��2��6   $��Center=�6#    �� Orientation$ 
Horizontal=�6@   $
��0,10q�6Y   .+�5      �� $��	Username:��6   $��0,0,10,0q�6(   $��Center=�6:   �� 5      -   5         ��Name$ TextBoxEnter��5      $	��200��6,   5      �� 5   
   $��3��6   $��Center=�6#   $ 
Horizontal=�6@   $
��0,10q�6Y   .+�5      �� $��	Password:��6   $��0,0,10,0q�6(   $��Center=�6:   G� 5      -   5         G�Name$ PasswordBoxEnter��5      $	��200��64   5       �� 5"   
   -   5         ��Name$ StackPanelButtonEnter��5"      $��4��64   $ 
Horizontal=�6A   $��Center=�6Z   $
��0,10q�6w   .+�5#      �� -   5        $��Login��5#      $	��100��6%   $��30��61   ���#76E3836R   �� 5$      -   5        $��Guest Login��5$      $	��100��6+   $��30��67   $��10,0,0,0q�6C   ���#498C516j   5%      �� 5'   
   $��5��6   $	��Top=�6!    �� TextAlignment$ Center=�69   �� 5(      $��Нет аккаунта?��6   $��10(�6,   6<    �� 5)      $*��$Зарегистрироваться��6   $��10(�62   ���#498C516W   5*      A� 5+   
   -	   5        $��UniformGridCaptcha��5+      $��4��60   $��3��6=   	 A� Columns$	 3��6Q   .+�5,        EasyCaptcha.Wpf.Captcha  -
   5        
  Name$
 	MyCaptcha��5,   &   $	��130��6   6&   �� 5-      -   5        $��TextBoxCaptcha��5-   "   $	��100��6   6"   �� 5.      -   5        $��ButtonAcceptCaptcha��5.      .��6R   ⊕6U   5/      50      51      