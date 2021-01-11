using System;
using System.Collections.Generic;
using System.Text;

namespace MapleStoryHelper.Standard.Common
{
    public enum EWindowsKeyCode
    {
        //
        // 요약:
        //     키를 누르지 않았습니다.
        None = 0,
        //
        // 요약:
        //     취소 키입니다.
        Cancel = 1,
        //
        // 요약:
        //     백스페이스 키입니다.
        Back = 2,
        //
        // 요약:
        //     <Tab> 키입니다.
        Tab = 3,
        //
        // 요약:
        //     줄 바꿈 키입니다.
        LineFeed = 4,
        //
        // 요약:
        //     지우기 키입니다.
        Clear = 5,
        //
        // 요약:
        //     Enter 키입니다.
        Return = 6,
        //
        // 요약:
        //     <Enter> 키입니다.
        Enter = 6,
        //
        // 요약:
        //     <Pause> 키입니다.
        Pause = 7,
        //
        // 요약:
        //     <Caps Lock> 키입니다.
        Capital = 8,
        //
        // 요약:
        //     <Caps Lock> 키입니다.
        CapsLock = 8,
        //
        // 요약:
        //     IME 가나 모드 키입니다.
        KanaMode = 9,
        //
        // 요약:
        //     IME 한글 모드 키입니다.
        HangulMode = 9,
        //
        // 요약:
        //     IME 전자 모드 키입니다.
        JunjaMode = 10,
        //
        // 요약:
        //     IME 최종 모드 키입니다.
        FinalMode = 11,
        //
        // 요약:
        //     IME 한자 모드 키입니다.
        HanjaMode = 12,
        //
        // 요약:
        //     IME 간지 모드 키입니다.
        KanjiMode = 12,
        //
        // 요약:
        //     <ESC> 키입니다.
        Escape = 13,
        //
        // 요약:
        //     IME 변환 키입니다.
        ImeConvert = 14,
        //
        // 요약:
        //     IME 변환 안 함 키입니다.
        ImeNonConvert = 15,
        //
        // 요약:
        //     IME 수락 키입니다.
        ImeAccept = 16,
        //
        // 요약:
        //     IME 모드 변경 요청입니다.
        ImeModeChange = 17,
        //
        // 요약:
        //     스페이스바 키입니다.
        Space = 18,
        //
        // 요약:
        //     <Page Up> 키입니다.
        Prior = 19,
        //
        // 요약:
        //     <Page Up> 키입니다.
        PageUp = 19,
        //
        // 요약:
        //     <Page Down> 키입니다.
        Next = 20,
        //
        // 요약:
        //     <Page Down> 키입니다.
        PageDown = 20,
        //
        // 요약:
        //     <End> 키입니다.
        End = 21,
        //
        // 요약:
        //     Home 키입니다.
        Home = 22,
        //
        // 요약:
        //     왼쪽 화살표 키입니다.
        Left = 23,
        //
        // 요약:
        //     위쪽 화살표 키입니다.
        Up = 24,
        //
        // 요약:
        //     오른쪽 화살표 키입니다.
        Right = 25,
        //
        // 요약:
        //     아래쪽 화살표 키입니다.
        Down = 26,
        //
        // 요약:
        //     선택 키입니다.
        Select = 27,
        //
        // 요약:
        //     인쇄 키입니다.
        Print = 28,
        //
        // 요약:
        //     실행 키입니다.
        Execute = 29,
        //
        // 요약:
        //     <Print Screen> 키입니다.
        Snapshot = 30,
        //
        // 요약:
        //     <Print Screen> 키입니다.
        PrintScreen = 30,
        //
        // 요약:
        //     <Insert> 키입니다.
        Insert = 31,
        //
        // 요약:
        //     <Delete> 키입니다.
        Delete = 32,
        //
        // 요약:
        //     도움말 키입니다.
        Help = 33,
        //
        // 요약:
        //     0 키입니다.
        D0 = 34,
        //
        // 요약:
        //     1 키입니다.
        D1 = 35,
        //
        // 요약:
        //     2 키입니다.
        D2 = 36,
        //
        // 요약:
        //     3 키입니다.
        D3 = 37,
        //
        // 요약:
        //     4 키입니다.
        D4 = 38,
        //
        // 요약:
        //     5 키입니다.
        D5 = 39,
        //
        // 요약:
        //     6 키입니다.
        D6 = 40,
        //
        // 요약:
        //     7 키입니다.
        D7 = 41,
        //
        // 요약:
        //     8 키입니다.
        D8 = 42,
        //
        // 요약:
        //     9 키입니다.
        D9 = 43,
        //
        // 요약:
        //     A 키입니다.
        A = 44,
        //
        // 요약:
        //     B 키입니다.
        B = 45,
        //
        // 요약:
        //     C 키입니다.
        C = 46,
        //
        // 요약:
        //     D 키입니다.
        D = 47,
        //
        // 요약:
        //     E 키입니다.
        E = 48,
        //
        // 요약:
        //     F 키입니다.
        F = 49,
        //
        // 요약:
        //     G 키입니다.
        G = 50,
        //
        // 요약:
        //     H 키입니다.
        H = 51,
        //
        // 요약:
        //     I 키입니다.
        I = 52,
        //
        // 요약:
        //     J 키입니다.
        J = 53,
        //
        // 요약:
        //     K 키입니다.
        K = 54,
        //
        // 요약:
        //     L 키입니다.
        L = 55,
        //
        // 요약:
        //     M 키입니다.
        M = 56,
        //
        // 요약:
        //     N 키입니다.
        N = 57,
        //
        // 요약:
        //     O 키입니다.
        O = 58,
        //
        // 요약:
        //     P 키입니다.
        P = 59,
        //
        // 요약:
        //     Q 키입니다.
        Q = 60,
        //
        // 요약:
        //     R 키입니다.
        R = 61,
        //
        // 요약:
        //     S 키입니다.
        S = 62,
        //
        // 요약:
        //     T 키입니다.
        T = 63,
        //
        // 요약:
        //     U 키입니다.
        U = 64,
        //
        // 요약:
        //     V 키입니다.
        V = 65,
        //
        // 요약:
        //     W 키입니다.
        W = 66,
        //
        // 요약:
        //     X 키입니다.
        X = 67,
        //
        // 요약:
        //     Y 키입니다.
        Y = 68,
        //
        // 요약:
        //     Z 키입니다.
        Z = 69,
        //
        // 요약:
        //     왼쪽 Windows 로고 키(Microsoft Natural 키보드)입니다.
        LWin = 70,
        //
        // 요약:
        //     오른쪽 Windows 로고 키(Microsoft Natural 키보드)입니다.
        RWin = 71,
        //
        // 요약:
        //     응용 프로그램 키(Microsoft Natural 키보드)입니다.
        Apps = 72,
        //
        // 요약:
        //     컴퓨터 절전 키입니다.
        Sleep = 73,
        //
        // 요약:
        //     숫자 키패드의 0 키입니다.
        NumPad0 = 74,
        //
        // 요약:
        //     숫자 키패드의 1 키입니다.
        NumPad1 = 75,
        //
        // 요약:
        //     숫자 키패드의 2 키입니다.
        NumPad2 = 76,
        //
        // 요약:
        //     숫자 키패드의 3 키입니다.
        NumPad3 = 77,
        //
        // 요약:
        //     숫자 키패드의 4 키입니다.
        NumPad4 = 78,
        //
        // 요약:
        //     숫자 키패드의 5 키입니다.
        NumPad5 = 79,
        //
        // 요약:
        //     숫자 키패드의 6 키입니다.
        NumPad6 = 80,
        //
        // 요약:
        //     숫자 키패드의 7 키입니다.
        NumPad7 = 81,
        //
        // 요약:
        //     숫자 키패드의 8 키입니다.
        NumPad8 = 82,
        //
        // 요약:
        //     숫자 키패드의 9 키입니다.
        NumPad9 = 83,
        //
        // 요약:
        //     곱하기 키입니다.
        Multiply = 84,
        //
        // 요약:
        //     추가 키입니다.
        Add = 85,
        //
        // 요약:
        //     구분 기호 키입니다.
        Separator = 86,
        //
        // 요약:
        //     빼기 키입니다.
        Subtract = 87,
        //
        // 요약:
        //     소수점 키입니다.
        Decimal = 88,
        //
        // 요약:
        //     나누기 키입니다.
        Divide = 89,
        //
        // 요약:
        //     F1 키입니다.
        F1 = 90,
        //
        // 요약:
        //     F2 키입니다.
        F2 = 91,
        //
        // 요약:
        //     F3 키입니다.
        F3 = 92,
        //
        // 요약:
        //     F4 키입니다.
        F4 = 93,
        //
        // 요약:
        //     F5 키입니다.
        F5 = 94,
        //
        // 요약:
        //     F6 키입니다.
        F6 = 95,
        //
        // 요약:
        //     F7 키입니다.
        F7 = 96,
        //
        // 요약:
        //     F8 키입니다.
        F8 = 97,
        //
        // 요약:
        //     F9 키입니다.
        F9 = 98,
        //
        // 요약:
        //     F10 키입니다.
        F10 = 99,
        //
        // 요약:
        //     F11 키입니다.
        F11 = 100,
        //
        // 요약:
        //     F12 키입니다.
        F12 = 101,
        //
        // 요약:
        //     F13 키입니다.
        F13 = 102,
        //
        // 요약:
        //     F14 키입니다.
        F14 = 103,
        //
        // 요약:
        //     F15 키입니다.
        F15 = 104,
        //
        // 요약:
        //     F16 키입니다.
        F16 = 105,
        //
        // 요약:
        //     F17 키입니다.
        F17 = 106,
        //
        // 요약:
        //     F18 키입니다.
        F18 = 107,
        //
        // 요약:
        //     F19 키입니다.
        F19 = 108,
        //
        // 요약:
        //     F20 키입니다.
        F20 = 109,
        //
        // 요약:
        //     F21 키입니다.
        F21 = 110,
        //
        // 요약:
        //     F22 키입니다.
        F22 = 111,
        //
        // 요약:
        //     F23 키입니다.
        F23 = 112,
        //
        // 요약:
        //     F24 키입니다.
        F24 = 113,
        //
        // 요약:
        //     <Num Lock> 키입니다.
        NumLock = 114,
        //
        // 요약:
        //     <Scroll Lock> 키입니다.
        Scroll = 115,
        //
        // 요약:
        //     왼쪽 <Shift> 키입니다.
        LeftShift = 116,
        //
        // 요약:
        //     오른쪽 <Shift> 키입니다.
        RightShift = 117,
        //
        // 요약:
        //     왼쪽 <Ctrl> 키입니다.
        LeftCtrl = 118,
        //
        // 요약:
        //     오른쪽 <Ctrl> 키입니다.
        RightCtrl = 119,
        //
        // 요약:
        //     왼쪽 <Alt> 키입니다.
        LeftAlt = 120,
        //
        // 요약:
        //     오른쪽 <Alt> 키입니다.
        RightAlt = 121,
        //
        // 요약:
        //     브라우저 뒤로 키입니다.
        BrowserBack = 122,
        //
        // 요약:
        //     브라우저 앞으로 키입니다.
        BrowserForward = 123,
        //
        // 요약:
        //     브라우저 새로 고침 키입니다.
        BrowserRefresh = 124,
        //
        // 요약:
        //     브라우저 중지 키입니다.
        BrowserStop = 125,
        //
        // 요약:
        //     브라우저 검색 키입니다.
        BrowserSearch = 126,
        //
        // 요약:
        //     브라우저 즐겨찾기 키입니다.
        BrowserFavorites = 127,
        //
        // 요약:
        //     브라우저 홈 키입니다.
        BrowserHome = 128,
        //
        // 요약:
        //     볼륨 음소거 키입니다.
        VolumeMute = 129,
        //
        // 요약:
        //     볼륨 작게 키입니다.
        VolumeDown = 130,
        //
        // 요약:
        //     볼륨 크게 키입니다.
        VolumeUp = 131,
        //
        // 요약:
        //     미디어 다음 트랙 키입니다.
        MediaNextTrack = 132,
        //
        // 요약:
        //     미디어 이전 트랙 키입니다.
        MediaPreviousTrack = 133,
        //
        // 요약:
        //     미디어 중지 키입니다.
        MediaStop = 134,
        //
        // 요약:
        //     미디어 재생 일시 중지 키입니다.
        MediaPlayPause = 135,
        //
        // 요약:
        //     메일 시작 키입니다.
        LaunchMail = 136,
        //
        // 요약:
        //     미디어 선택 키입니다.
        SelectMedia = 137,
        //
        // 요약:
        //     응용 프로그램1 시작 키입니다.
        LaunchApplication1 = 138,
        //
        // 요약:
        //     응용 프로그램2 시작 키입니다.
        LaunchApplication2 = 139,
        //
        // 요약:
        //     OEM 1 키입니다.
        Oem1 = 140,
        //
        // 요약:
        //     OEM 세미콜론 키입니다.
        OemSemicolon = 140,
        //
        // 요약:
        //     OEM 추가 키입니다.
        OemPlus = 141,
        //
        // 요약:
        //     OEM 쉼표 키입니다.
        OemComma = 142,
        //
        // 요약:
        //     OEM 빼기 키입니다.
        OemMinus = 143,
        //
        // 요약:
        //     OEM 마침표 키입니다.
        OemPeriod = 144,
        //
        // 요약:
        //     OEM 2 키입니다.
        Oem2 = 145,
        //
        // 요약:
        //     OEM 물음표 키입니다.
        OemQuestion = 145,
        //
        // 요약:
        //     OEM 3 키입니다.
        Oem3 = 146,
        //
        // 요약:
        //     OEM 물결표 키입니다.
        OemTilde = 146,
        //
        // 요약:
        //     ABNT_C1(브라질) 키입니다.
        AbntC1 = 147,
        //
        // 요약:
        //     ABNT_C2(브라질) 키입니다.
        AbntC2 = 148,
        //
        // 요약:
        //     OEM 4 키입니다.
        Oem4 = 149,
        //
        // 요약:
        //     OEM 여는 괄호 키입니다.
        OemOpenBrackets = 149,
        //
        // 요약:
        //     OEM 5 키입니다.
        Oem5 = 150,
        //
        // 요약:
        //     OEM 파이프 키입니다.
        OemPipe = 150,
        //
        // 요약:
        //     OEM 6 키입니다.
        Oem6 = 151,
        //
        // 요약:
        //     OEM 닫는 괄호 키입니다.
        OemCloseBrackets = 151,
        //
        // 요약:
        //     OEM 7 키입니다.
        Oem7 = 152,
        //
        // 요약:
        //     OEM 따옴표 키입니다.
        OemQuotes = 152,
        //
        // 요약:
        //     OEM 8 키입니다.
        Oem8 = 153,
        //
        // 요약:
        //     OEM 102 키입니다.
        Oem102 = 154,
        //
        // 요약:
        //     OEM 백슬래시 키입니다.
        OemBackslash = 154,
        //
        // 요약:
        //     IME에서 처리될 실제 키를 마스킹하는 특수 키입니다.
        ImeProcessed = 155,
        //
        // 요약:
        //     시스템 키로 처리될 실제 키를 마스킹하는 특수 키입니다.
        System = 156,
        //
        // 요약:
        //     OEM ATTN 키입니다.
        OemAttn = 157,
        //
        // 요약:
        //     DBE_ALPHANUMERIC 키입니다.
        DbeAlphanumeric = 157,
        //
        // 요약:
        //     OEM 마침 키입니다.
        OemFinish = 158,
        //
        // 요약:
        //     DBE_KATAKANA 키입니다.
        DbeKatakana = 158,
        //
        // 요약:
        //     OEM 복사 키입니다.
        OemCopy = 159,
        //
        // 요약:
        //     DBE_HIRAGANA 키입니다.
        DbeHiragana = 159,
        //
        // 요약:
        //     OEM 자동 키입니다.
        OemAuto = 160,
        //
        // 요약:
        //     DBE_SBCSCHAR 키입니다.
        DbeSbcsChar = 160,
        //
        // 요약:
        //     OEM ENLW 키입니다.
        OemEnlw = 161,
        //
        // 요약:
        //     DBE_DBCSCHAR 키입니다.
        DbeDbcsChar = 161,
        //
        // 요약:
        //     OEM BACKTAB 키입니다.
        OemBackTab = 162,
        //
        // 요약:
        //     DBE_ROMAN 키입니다.
        DbeRoman = 162,
        //
        // 요약:
        //     ATTN 키입니다.
        Attn = 163,
        //
        // 요약:
        //     DBE_NOROMAN 키입니다.
        DbeNoRoman = 163,
        //
        // 요약:
        //     CRSEL 키입니다.
        CrSel = 164,
        //
        // 요약:
        //     DBE_ENTERWORDREGISTERMODE 키입니다.
        DbeEnterWordRegisterMode = 164,
        //
        // 요약:
        //     EXSEL 키입니다.
        ExSel = 165,
        //
        // 요약:
        //     DBE_ENTERIMECONFIGMODE 키입니다.
        DbeEnterImeConfigureMode = 165,
        //
        // 요약:
        //     ERASE EOF 키입니다.
        EraseEof = 166,
        //
        // 요약:
        //     DBE_FLUSHSTRING 키입니다.
        DbeFlushString = 166,
        //
        // 요약:
        //     재생 키입니다.
        Play = 167,
        //
        // 요약:
        //     DBE_CODEINPUT 키입니다.
        DbeCodeInput = 167,
        //
        // 요약:
        //     확대/축소 키입니다.
        Zoom = 168,
        //
        // 요약:
        //     DBE_NOCODEINPUT 키입니다.
        DbeNoCodeInput = 168,
        //
        // 요약:
        //     나중에 사용하기 위해 예약된 상수입니다.
        NoName = 169,
        //
        // 요약:
        //     DBE_DETERMINESTRING 키입니다.
        DbeDetermineString = 169,
        //
        // 요약:
        //     PA1 키입니다.
        Pa1 = 170,
        //
        // 요약:
        //     DBE_ENTERDLGCONVERSIONMODE 키입니다.
        DbeEnterDialogConversionMode = 170,
        //
        // 요약:
        //     OEM 지우기 키입니다.
        OemClear = 171,
        //
        // 요약:
        //     키는 조합된 단일 문자를 만들기 위해 다른 키와 함께 사용됩니다.
        DeadCharProcessed = 172
    }
}
