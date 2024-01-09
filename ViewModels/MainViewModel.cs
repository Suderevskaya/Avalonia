using Avalonia.Controls;
using AvaloniaApplication1.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
namespace AvaloniaApplication1.ViewModels;

public class MainViewModel : ViewModelBase
{
    //public string Greeting => "Welcome to Avalonia!";
    
    string[] text = {"Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk",
    "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk", "Cornsilk"};
    public string Color0 { get => text[0]; set => this.RaiseAndSetIfChanged(ref text[0], value); }
    public static class ForCheck
    {
        public static int[] input = [0, 0, 0, 0, 0];
        public static int[] num = [0, 0, 0, 0, 0];
        public static int count = 0;
    }
    public void Check(int count, int[] num, int[] input)
    {
        bool check = true;
        for (int i = 0; i < 5; i++)
        {
            if ((num[i] != input[i]) || (num[i] == 0) || (input[i] == 0))
            {
                check = false;
            }
        }
        for (int i = 0; i < 5; i++)
        {
            num[i] = 0;
            input[i] = 0;
        }
        count = 0;
        if (check == false)
        {
            Fail();
        }
        else Win();
    }
    public static void Fail() {
        var window = new FailWindow();
        window.Show();
    }
    public static void Win() {
        var window = new WinWindow();
        window.Show();
    }
    public void SetColor(int num, string value) {
        switch (num)
        {
            case 100:
                Color100 = value;
                break;
            case 101:
                Color101 = value;
                break;
            case 102:
                Color102 = value;
                break;
            case 103:
                Color103 = value;
                break;
            case 104:
                Color104 = value;
                break;
            case 105:
                Color105 = value;
                break;
            case 106:
                Color106 = value;
                break;
            case 107:
                Color107 = value;
                break;
            case 108:
                Color108 = value;
                break;
            case 109:
                Color109 = value;
                break;
            case 110:
                Color110 = value;
                break;
            case 111:
                Color111 = value;
                break;
            case 112:
                Color112 = value;
                break;
            case 113:
                Color113 = value;
                break;
            case 114:
                Color114 = value;
                break;
            case 115:
                Color115 = value;
                break;
            case 116:
                Color116 = value;
                break;
            case 117:
                Color117 = value;
                break;
            case 118:
                Color118 = value;
                break;
            case 119:
                Color119 = value;
                break;
            case 120:
                Color120 = value;
                break;
            case 121:
                Color121 = value;
                break;
            case 122:
                Color122 = value;
                break;
            case 123:
                Color123 = value;
                break;
            case 124:
                Color124 = value;
                break;
        }
    }
    public string Color1 { get => text[1]; set => this.RaiseAndSetIfChanged(ref text[1], value); }
    public string Color2 { get => text[2]; set => this.RaiseAndSetIfChanged(ref text[2], value); }
    public string Color3 { get => text[3]; set => this.RaiseAndSetIfChanged(ref text[3], value); }
    public string Color4 { get => text[4]; set => this.RaiseAndSetIfChanged(ref text[4], value); }
    public string Color5 { get => text[5]; set => this.RaiseAndSetIfChanged(ref text[5], value); }
    public string Color6 { get => text[6]; set => this.RaiseAndSetIfChanged(ref text[6], value); }
    public string Color7 { get => text[7]; set => this.RaiseAndSetIfChanged(ref text[7], value); }
    public string Color8 { get => text[8]; set => this.RaiseAndSetIfChanged(ref text[8], value); }
    public string Color9 { get => text[9]; set => this.RaiseAndSetIfChanged(ref text[9], value); }
    public string Color10 { get => text[10]; set => this.RaiseAndSetIfChanged(ref text[10], value); }
    public string Color11 { get => text[11]; set => this.RaiseAndSetIfChanged(ref text[11], value); }
    public string Color12 { get => text[12]; set => this.RaiseAndSetIfChanged(ref text[12], value); }
    public string Color13 { get => text[13]; set => this.RaiseAndSetIfChanged(ref text[13], value); }
    public string Color14 { get => text[14]; set => this.RaiseAndSetIfChanged(ref text[14], value); }
    public string Color15 { get => text[15]; set => this.RaiseAndSetIfChanged(ref text[15], value); }
    public string Color16 { get => text[16]; set => this.RaiseAndSetIfChanged(ref text[16], value); }
    public string Color17 { get => text[17]; set => this.RaiseAndSetIfChanged(ref text[17], value); }
    public string Color18 { get => text[18]; set => this.RaiseAndSetIfChanged(ref text[18], value); }
    public string Color19 { get => text[19]; set => this.RaiseAndSetIfChanged(ref text[19], value); }
    public string Color20 { get => text[20]; set => this.RaiseAndSetIfChanged(ref text[20], value); }
    public string Color21 { get => text[21]; set => this.RaiseAndSetIfChanged(ref text[21], value); }
    public string Color22 { get => text[22]; set => this.RaiseAndSetIfChanged(ref text[22], value); }
    public string Color23 { get => text[23]; set => this.RaiseAndSetIfChanged(ref text[23], value); }
    public string Color24 { get => text[24]; set => this.RaiseAndSetIfChanged(ref text[24], value); }
    public string Color100 { get => text[25]; set => this.RaiseAndSetIfChanged(ref text[25], value); }
    public string Color101 { get => text[26]; set => this.RaiseAndSetIfChanged(ref text[26], value); }
    public string Color102 { get => text[27]; set => this.RaiseAndSetIfChanged(ref text[27], value); }
    public string Color103 { get => text[28]; set => this.RaiseAndSetIfChanged(ref text[28], value); }
    public string Color104 { get => text[29]; set => this.RaiseAndSetIfChanged(ref text[29], value); }
    public string Color105 { get => text[30]; set => this.RaiseAndSetIfChanged(ref text[30], value); }
    public string Color106 { get => text[31]; set => this.RaiseAndSetIfChanged(ref text[31], value); }
    public string Color107 { get => text[32]; set => this.RaiseAndSetIfChanged(ref text[32], value); }
    public string Color108 { get => text[33]; set => this.RaiseAndSetIfChanged(ref text[33], value); }
    public string Color109 { get => text[34]; set => this.RaiseAndSetIfChanged(ref text[34], value); }
    public string Color110 { get => text[35]; set => this.RaiseAndSetIfChanged(ref text[35], value); }
    public string Color111 { get => text[36]; set => this.RaiseAndSetIfChanged(ref text[36], value); }
    public string Color112 { get => text[37]; set => this.RaiseAndSetIfChanged(ref text[37], value); }
    public string Color113 { get => text[38]; set => this.RaiseAndSetIfChanged(ref text[38], value); }
    public string Color114 { get => text[39]; set => this.RaiseAndSetIfChanged(ref text[39], value); }
    public string Color115 { get => text[40]; set => this.RaiseAndSetIfChanged(ref text[40], value); }
    public string Color116 { get => text[41]; set => this.RaiseAndSetIfChanged(ref text[41], value); }
    public string Color117 { get => text[42]; set => this.RaiseAndSetIfChanged(ref text[42], value); }
    public string Color118 { get => text[43]; set => this.RaiseAndSetIfChanged(ref text[43], value); }
    public string Color119 { get => text[44]; set => this.RaiseAndSetIfChanged(ref text[44], value); }
    public string Color120 { get => text[45]; set => this.RaiseAndSetIfChanged(ref text[45], value); }
    public string Color121 { get => text[46]; set => this.RaiseAndSetIfChanged(ref text[46], value); }
    public string Color122 { get => text[47]; set => this.RaiseAndSetIfChanged(ref text[47], value); }
    public string Color123 { get => text[48]; set => this.RaiseAndSetIfChanged(ref text[48], value); }
    public string Color124 { get => text[48]; set => this.RaiseAndSetIfChanged(ref text[49], value); }
}