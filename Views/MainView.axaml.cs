using Avalonia.Controls;
using AvaloniaApplication1.ViewModels;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using static AvaloniaApplication1.ViewModels.MainViewModel;

namespace AvaloniaApplication1.Views;

static class Constants
{
    public const int time = 2000;
}

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();        
    }
    async private void ClickStart(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

        for (int i = 0; i < 5; i++)
        {
            ForCheck.num[i] = 0;
            ForCheck.input[i] = 0;
        }
        ForCheck.count = 0;
        var rand = new Random();
        ForCheck.num[0] = rand.Next(100, 124);
        (DataContext as MainViewModel).SetColor(ForCheck.num[0], "LightGreen");
        await Task.Delay(Constants.time);
        (DataContext as MainViewModel).SetColor(ForCheck.num[0], "Cornsilk");
        ForCheck.num[1] = rand.Next(100, 124);
        (DataContext as MainViewModel).SetColor(ForCheck.num[1], "LightGreen");
        await Task.Delay(Constants.time);
        (DataContext as MainViewModel).SetColor(ForCheck.num[1], "Cornsilk");
        ForCheck.num[2] = rand.Next(100, 124);
        (DataContext as MainViewModel).SetColor(ForCheck.num[2], "LightGreen");
        await Task.Delay(Constants.time);
        (DataContext as MainViewModel).SetColor(ForCheck.num[2], "Cornsilk");
        ForCheck.num[3] = rand.Next(100, 124);
        (DataContext as MainViewModel).SetColor(ForCheck.num[3], "LightGreen");
        await Task.Delay(Constants.time);
        (DataContext as MainViewModel).SetColor(ForCheck.num[3], "Cornsilk");
        ForCheck.num[4] = rand.Next(100, 124);
        (DataContext as MainViewModel).SetColor(ForCheck.num[4], "LightGreen");
        await Task.Delay(Constants.time);
        (DataContext as MainViewModel).SetColor(ForCheck.num[4], "Cornsilk");
    }
    private void ClickCheck(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";

        (DataContext as MainViewModel).Check(ForCheck.count, ForCheck.num, ForCheck.input);
    }
    private void ClickButton0(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color0 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 100;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color0;
            (DataContext as MainViewModel).Color0 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton1(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color1 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 101;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color1;
            (DataContext as MainViewModel).Color1 = "LightGreen";
        }
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton2(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color2 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 102;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color2;
            (DataContext as MainViewModel).Color2 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton3(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color3 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 103;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color3;
            (DataContext as MainViewModel).Color3 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton4(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color4 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 104;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color4;
            (DataContext as MainViewModel).Color4 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton5(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color5 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 105;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color5;
            (DataContext as MainViewModel).Color5 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton6(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color6 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 106;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color6;
            (DataContext as MainViewModel).Color6 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton7(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color7 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 107;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color7;
            (DataContext as MainViewModel).Color7 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton8(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color8 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 108;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color8;
            (DataContext as MainViewModel).Color8 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton9(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color9 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 109;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color9;
            (DataContext as MainViewModel).Color9 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton10(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color10 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 110;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color10;
            (DataContext as MainViewModel).Color10 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton11(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color11 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 111;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color11;
            (DataContext as MainViewModel).Color11 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton12(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color12 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 112;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color12;
            (DataContext as MainViewModel).Color12 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton13(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color13 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 113;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color13;
            (DataContext as MainViewModel).Color13 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton14(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color14 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 114;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color14;
            (DataContext as MainViewModel).Color14 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton15(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color15 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 115;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color15;
            (DataContext as MainViewModel).Color15 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton16(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color16 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 116;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color16;
            (DataContext as MainViewModel).Color16 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton17(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color17 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 117;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color17;
            (DataContext as MainViewModel).Color17 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton18(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color18 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 118;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color18;
            (DataContext as MainViewModel).Color18 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton19(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color19 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 119;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color19;
            (DataContext as MainViewModel).Color19 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton20(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color20 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 120;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color10;
            (DataContext as MainViewModel).Color20 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton21(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color21 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 121;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color21;
            (DataContext as MainViewModel).Color21 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton22(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color22 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 122;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color22;
            (DataContext as MainViewModel).Color22 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton23(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color23 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 123;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color23;
            (DataContext as MainViewModel).Color23 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
        (DataContext as MainViewModel).Color24 = "Cornsilk";
    }
    private void ClickButton24(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (ForCheck.count > 4)
        {
            Fail();
            (DataContext as MainViewModel).Color24 = "Cornsilk";
        }
        else
        {
            ForCheck.input[ForCheck.count] = 124;
            ForCheck.count++;
            var oldvalue1 = (DataContext as MainViewModel).Color24;
            (DataContext as MainViewModel).Color24 = "LightGreen";
        }
        (DataContext as MainViewModel).Color1 = "Cornsilk";
        (DataContext as MainViewModel).Color2 = "Cornsilk";
        (DataContext as MainViewModel).Color3 = "Cornsilk";
        (DataContext as MainViewModel).Color4 = "Cornsilk";
        (DataContext as MainViewModel).Color5 = "Cornsilk";
        (DataContext as MainViewModel).Color6 = "Cornsilk";
        (DataContext as MainViewModel).Color7 = "Cornsilk";
        (DataContext as MainViewModel).Color8 = "Cornsilk";
        (DataContext as MainViewModel).Color9 = "Cornsilk";
        (DataContext as MainViewModel).Color10 = "Cornsilk";
        (DataContext as MainViewModel).Color11 = "Cornsilk";
        (DataContext as MainViewModel).Color12 = "Cornsilk";
        (DataContext as MainViewModel).Color13 = "Cornsilk";
        (DataContext as MainViewModel).Color14 = "Cornsilk";
        (DataContext as MainViewModel).Color15 = "Cornsilk";
        (DataContext as MainViewModel).Color16 = "Cornsilk";
        (DataContext as MainViewModel).Color17 = "Cornsilk";
        (DataContext as MainViewModel).Color18 = "Cornsilk";
        (DataContext as MainViewModel).Color19 = "Cornsilk";
        (DataContext as MainViewModel).Color20 = "Cornsilk";
        (DataContext as MainViewModel).Color21 = "Cornsilk";
        (DataContext as MainViewModel).Color22 = "Cornsilk";
        (DataContext as MainViewModel).Color23 = "Cornsilk";
        (DataContext as MainViewModel).Color0 = "Cornsilk";
    }
}
